const snapsso         = require('./snap-sso')
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

//console.log(encFields)
let req = {        
    email: opts.email || 'd31@mailinator.com',
    name: opts.name || 'd31',
    role: opts.role || 'patient'
}

snapsso.getUrl(req, opts, accessurl => {
  console.log('req:', req, 'opts', opts, '\n', 'accessurl:', accessurl)
}, err => {
  console.log('err:', err)
})
