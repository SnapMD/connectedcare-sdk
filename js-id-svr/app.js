const express       = require('express')
const cookieParser  = require('cookie-parser')
const bodyParser    = require('body-parser')
const crypto        = require('crypto')
const uuid          = require('uuid')
const request       = require('request')

const app           = express()

const port            = process.env.PORT || '5001'

app.use(cookieParser())
app.use(bodyParser.json()) // support json encoded bodies
app.use(bodyParser.urlencoded({ extended: true })) // support encoded bodies

app.use(express.static('html', {
  extensions: ['html']
}))

app.listen(port, function () {
  console.log('js-id-svr listening on port ', port, '!')
})
