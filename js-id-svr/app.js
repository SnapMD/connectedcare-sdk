const express       = require('express')
const cookieParser  = require('cookie-parser')
const bodyParser    = require('body-parser')
const crypto        = require('crypto')
const uuid          = require('uuid')
const request       = require('request')
const snapsso       = require('./snap-sso')
const config        = require('./config.json')

const port          = process.env.PORT || '5001'
const app           = express()

app.use(cookieParser())
app.use(bodyParser.json()) // support json encoded bodies
app.use(bodyParser.urlencoded({ extended: true })) // support encoded bodies

app.use(express.static('html', {
  extensions: ['html']
}))

app.get('/api/hosts', (req, res) => {
  res.json(config.hosts)
})

app.get('/api/langs', (req, res) => {
  res.json(config.langs)
})

app.get('/api/fees', (req, res) => {
  res.json(config.fees)
})

app.post('/api/sso-sessions', function(req, res) {
	console.log('req.body:', req.body)
  let rq = req.body.req
  let op = req.body.opts
  let user = config.users.find(x => x.email == rq.email)
  let ok = user && user.pass == rq.pass && user.hosts.find(x => x == op.host.name)
  if (!ok) {
    res.status(401).json({ error: 'User Not Found' })
    return
  }
	snapsso.getUrl(rq, op, accessurl => {
	  console.log('accessurl:', accessurl)
	  res.json({ url: accessurl })
	}, err => {
    console.log('err:', err)
    res.status(response.statusCode).json({ error: err })
	})
})

app.listen(port, function () {
  console.log('js-id-svr listening on port ', port, '!')
})
