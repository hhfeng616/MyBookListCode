const mysql      = require('mysql');
const connection = mysql.createConnection({
    host     : 'localhost',
    user     : 'root',
    password : '86833695',
    database : 'student'
});
connection.connect(function(err) {
    if (err) {
        console.error('error connecting: ' + err.stack);
        return;
    }
    console.log('connected as id ' + connection.threadId);
});
const table = 'student';

connection.query('SELECT * FROM ?',[table], function(err, rows) {
    if(err) {
        console.log(err);
    } else {
        console.log(rows);
    }
});
