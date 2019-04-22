const fs          = require('fs')
const jwt         = require('jsonwebtoken')
const aesjs       = require('aes-js')
const crypto      = require('crypto')
const uuid        = require('uuid')
const bytesToUuid = require('uuid/lib/bytesToUuid');

const jwtexp      = process.env.JWTEXP || '5m'

function encrypt(key, iv, data) {
    let cipher = crypto.createCipheriv('aes-128-cbc', key, iv)
    return cipher.update(data, 'utf8', 'base64') + cipher.final('base64')
};

exports.getUrl = (req, opts, success, error) => {
  opts = opts || {}
  let secret = opts.secret || 'TextSizeMustBe16'
  let privatekey = fs.readFileSync('private.pem')

  let signOptions = {
      algorithm:  opts.alg || 'RS256',
      audience:   opts.aud || 'snapmd',
      issuer:     opts.iss || 'snapmd',
      subject:    opts.sub || 'snapmd',
      expiresIn:  jwtexp
  };

  let jti = uuid('binary') 

  req.jti   = bytesToUuid(jti)
  req.role  = req.role || opts.role || 'patient'
  jwt.sign(req, privatekey, signOptions, (err, token) => {
    let debug = opts.debug
    if (debug) {
      debug.signOptions = signOptions
      debug.token = token
      debug.err = err
    }

    if (token != undefined) {
      let host = opts.host || 'snap.local'
      let ssop = encrypt(secret, Buffer.from(jti), aesjs.utils.utf8.toBytes(JSON.stringify({fee: opts.fee})))
      let url = `https://${host}/${req.role}.access?jwt=${token}&op=${ssop}&language=${opts.lang}`
      if (success)
        success(url, req, opts)
    } else {
      if (error)
        error(err)
    }
  })
}