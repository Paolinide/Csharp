const sql = require('mssql');

module.exports = class Users {
    constructor(username, fullName, birthDate, id = null) {
        // definisco gli attributi privati (come prassi) tramite l'underscore
        this._id = id;
        this._username = username;
        this._fullName = fullName;
        this._birthDate = birthDate;

        
    }
    // adesso la gestione delle proprietà
    get username() {
        return this._username;
    }
    get fullName() {
        return this._fullName;
    }
    get birthDate() {
        return this._birthDate;
    }
    get id() {
        return this._id;
    }

    set username(value) {
        this._username = value;
    }
    set fullName(value) {
        this._fullName = value;
    }
    set id(value) {
        this._id = value;
    }
    // il metodo che salva i dati, prende la configurazione del db mssql
    async save(dbConfig) {
        // TODO  inserire try catch
        let db = await sql.connect(dbConfig);
        // per distinguere se è un update o un insert into
        let query = 'INSERT INTO dbo.Users ([username],[fullName],[birthDate],[CorsoITS],[StudentName]) VALUES ( @username,@fullName,@birthDate,\'DAM\',\'Mauro Biasutti\')';
        console.log(query);
        if (this._id) {
            query = 'UPDATE dbo.libri SET [username]=@username, [fullName]=@fullName, [birthDate]=@birthDate WHERE id=@id'
        }
        let libroSalvato = await db.request()

            .input('username', sql.NVarChar, this.username)
            .input('fullName', sql.NVarChar, this.fullName)
            .input('birthDate', sql.NVarChar, this.birthDate)
            .input('id', sql.Int, this._id)
            .query(query);

        console.log('sto salvando i dati dell\'utente ');
        sql.close();
        return true;

    }

    toJson() {
        return JSON.stringify({ username: this.username, fullName: this.fullName, birthDate: this.birthDate, id: this.id });
    }


    static async  retrieve(dbConfig,id) {
        let db = await sql.connect(dbConfig);
        let queryID = '1=1';
        if (id) {
            queryID = 'id=@id'
        }
        let query = 'SELECT  [username],[fullName],[birthDate],[id] FROM  dbo.Users WHERE ';
        query = query + queryID;
        console.log(query)

        let userRetrieved = await db.request()
            .input('id', sql.Int, id)
            .query(query);
        let user = new Array();
        console.log(userRetrieved)

        
        if (userRetrieved.recordset.length > 0) {

            userRetrieved.recordset.forEach(userN => {
                user.push(new Users(userN.username,
                                    userN.fullName,
                                    userN.birthDate,
                                    userN.id))
            });

        } else {
            user = null;
        }
        sql.close();
        console.log(user)
        return user;
    }
    
}

