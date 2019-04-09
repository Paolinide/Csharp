//-------------------------------------------------------------------------------------------
// importiamo il server HTTP
const fastify = require('fastify')({
    logger: true,
    ignoreTrailingSlash: true
});

//-------------------------------------------------------------------------------------------
// configurazione per il collegamento a SQL Server
const sql = require('mssql');
// ATTENZIONE!!!!!!!!!
//  cambiare prima di spedire



const config = {
    user: 'user',
    password: 'Test100%',
    server: 'dottor-its.database.windows.net',
    database: 'its',
    port: 1433,
    options: {
        encrypt: true
    }
};


// importo le classi User e Event per poter gestire le operazioni sul DB
const User  = require('./users');
const Event = require('./events')

// test spicciolo per vedere se funziona

fastify.post('/', (req, reply) => {
    reply.send(req.body)
})


//---------   users API  --------------------------------------------
// Lista---OK
fastify.get('/api/users/', (req, reply) => {
    try {
        return User.retrieve(config);
    } catch (error) {
        reply.status(500).send({
            statusCode: 500,
            error: error,
            message: "Qualche problema!"
        });}
    
})

// Dettaglio----OK
fastify.get('/api/users/:id', (request, reply) => {
    return User.retrieve(config,request.params['id']);
})
// Inserimento- e modifica --- OK
fastify.post('/api/users', (request, reply) => {
    let model = request.body;
    let userX = new User(model.username, model.fullName,model.birthDate,model.id);
    if (userX.save(config)) {
        reply.status(201).send({
            statusCode: 201,
            error: null,
            message: "tutto ok, inserito utente"
        });
    }
    else {
        reply.status(500).send({
            statusCode: 500,
            error: "generico",
            message: "c'è stato qualche problema nell'inserimento del nuovo utente"
        });
    }
})

//---------   events API  --------------------------------------------
//url: /api/events

// Lista
fastify.get('/api/events/', (req, reply) => {
    try {
        return Event.retrieve(config);
    } catch (error) {
        reply.status(500).send({
            statusCode: 500,
            error: error,
            message: "Qualche problema!"
        });}
    
})

// Dettaglio
fastify.get('/api/events/:id', (request, reply) => {
    return User.retrieve( config,request.params['id']);
})
// Inserimento e modifica
fastify.post('/api/events', (request, reply) => {
    let model = request.body;
    let eventX = new Event(model.Location, model.MaxUsers ,model.StartDate, model.EndDate,model.id);
    if (eventX.save(config)) {
        reply.status(201).send({
            statusCode: 201,
            error: null,
            message: "tutto ok, inserito evento"
        });
    }
    else {
        reply.status(500).send({
            statusCode: 500,
            error: "generico",
            message: "c'è stato qualche problema nell'inserimento del nuovo evento"
        });
    }
})


// Run the server!
const start = async () => {
    try {
        await fastify.listen(3001)
        fastify.log.info(`server listening on ${fastify.server.address().port}`)
    } catch (err) {
        fastify.log.error(err)
        process.exit(1)
    }
}

start();