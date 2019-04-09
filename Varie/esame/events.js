const sql = require('mssql');

module.exports = class Events {
    constructor(Location,MaxUsers,StartDate,EndDate, id = null) {
        // definisco gli attributi privati (come prassi) tramite l'underscore
        this._id = id;
        this._Location = Location;
        this._MaxUsers = MaxUsers;
        this._StartDate = StartDate;
        this._EndDate = EndDate;

    }
    // adesso la gestione delle proprietà
    get Location() {
        return this._Location;
    }
    get MaxUsers() {
        return this._MaxUsers;
    }
    get StartDate() {
        return this._StartDate;
    }
    get EndDate() {
        return this._EndDate;
    }
    get id() {
        return this._id;
    }

    set Location(value) {
        this._Location = value;
    }
    set MaxUsers(value) {
        this._MaxUsers = value;
    }
    set StartDate(value) {
        this._StartDate = value;
    }
    set EndDate(value) {
        this._EndDate = value;
    }
    set id(value) {
        this._id = value;
    }
    // il metodo che salva i dati, prende la configurazione del db mssql
    async save(dbConfig) {
        // TODO  inserire try catch
        let db = await sql.connect(dbConfig);
        // per distinguere se è un update o un insert into
        let query = 'INSERT INTO dbo.Events ([Location],[MaxUsers],[StartDate],[EndDate],[CorsoITS],[StudentName]) VALUES ( @Location,@MaxUsers,@StartDate,@EndDate,\'DAM\',\'Mauro Biasutti\')';
        console.log(query);
        if (this._id) {
            query = 'UPDATE dbo.Events SET [Location]=@Location, [MaxUsers]=@MaxUsers, [StartDate]=@StartDate, [EndDate]=@EndDate WHERE id=@id'
        }
        let EventSaved = await db.request()

            .input('Location', sql.NVarChar, this.Location)
            .input('MaxUsers', sql.Int, this.MaxUsers)
            .input('StartDate', sql.NVarChar, this.StartDate)
            .input('EndDate', sql.NVarChar, this.EndDate)
            .input('id', sql.Int, this._id)
            .query(query);

        console.log('sto salvando i dati dell\'evento ');
        sql.close();
        return true;

    }

    toJson() {
        return JSON.stringify({ Location: this.Location, MaxUsers: this.MaxUsers, startDate: this.StartDate,EndDate: this.EndDate, id: this.id });
    }


    static async  retrieve(dbConfig,id) {
        let db = await sql.connect(dbConfig);
        let queryID = '1=1';
        if (id) {
            queryID = 'id=@id'
        }
        let query = 'SELECT  [Location],[MaxUsers],[StartDate],[EndDate],[id] FROM  dbo.Events WHERE ';
        query = query + queryID;
        console.log(query)

        let eventsRetrieved = await db.request()
            .input('id', sql.Int, id)
            .query(query);
        let event = new Array();
        console.log(eventsRetrieved)

        
        if (eventsRetrieved.recordset.length > 0) {

            eventsRetrieved.recordset.forEach(eventN => {
                event.push(new Events(eventN.Location,
                                    eventN.MaxUsers,
                                    eventN.StartDate,
                                    eventN.EndDate,
                                    eventN.id))
            });

        } else {
            event = null;
        }
        sql.close();
        console.log(event)
        return event;
    }
    



}

