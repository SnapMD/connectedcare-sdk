const fs = require('fs')
const jwt = require('jsonwebtoken')
const aesjs = require('aes-js')
const crypto = require('crypto')
const uuid = require('uuid')
const bytesToUuid = require('uuid/lib/bytesToUuid');
const commandLineArgs = require('command-line-args')

const optionDefinitions = [
  { name: 'fee', alias: 'f', type: Number },
  { name: 'email', alias: 'e', type: String },
  { name: 'host', alias: 'h', type: String },
  { name: 'lang', alias: 'l', type: String },
  { name: 'name', alias: 'n', type: String },
  { name: 'role', alias: 'r', type: String },
  { name: 'secret', alias: 's', type: String }
]
const opts = commandLineArgs(optionDefinitions)

let privatekey = fs.readFileSync('private.pem')

let signOptions = {
    audience: 'snapmd',
    issuer: 'snapmd',
    subject:  'snapmd',
    expiresIn:  "12h",
    algorithm:  "RS256"
};

let secret = opts.secret || 'TextSizeMustBe16'
let jti = uuid('binary') //'c8e4d6b8-e1aa-4c23-a2f8-b81ca1563fde'// base64 of 'c8e4d6b8-e1aa-4c23-a2f8-b81ca1563fde'

//let iv = new Buffer('uNbkyKrhI0yi+LgcoVY/3g==', 'base64') // uNbkyKrhI0yi+LgcoVY/3g== (base64 of 'c8e4d6b8-e1aa-4c23-a2f8-b81ca1563fde')

// Convert text to bytes (text must be a multiple of 16 bytes)
let option = {
    fee: opts.fee || 20
}
let textBytes = aesjs.utils.utf8.toBytes(JSON.stringify(option));
 

var encrypt = function (key, iv, data) {
    var cipher = crypto.createCipheriv('aes-128-cbc', key, iv); 
    var crypted = cipher.update(data, 'utf8', 'base64');
    crypted += cipher.final('base64');
    return crypted;
};

let encFields = encrypt(secret, Buffer.from(jti), textBytes)

//console.log(encFields)
let req = {        
    jti: bytesToUuid(jti),
    email: opts.email || 'd31@mailinator.com',
    name: opts.name || 'd31',
    role: opts.role || 'patient'
}

jwt.sign(req, privatekey, signOptions, (err, token) => {
        if (token != undefined) {
            let accessurl = `https://${opts.host||'snap.local'}/${req.role}.access?jwt=${token}&op=${encFields}&language=${opts.lang}`
            console.log('option', option, 'req:', req, '\n', 'accessurl:', accessurl)
        } else {
            console.log('err:', err)
        }
    }
)
