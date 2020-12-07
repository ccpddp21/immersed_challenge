const express = require('express');
const app = express();

const auth = require('./routes/auth');
const rooms = require('./routes/rooms');

app.use('/auth', auth);
app.use('/rooms', rooms);

app.listen(3000, () => console.log('Gator app listening on port 3000!'));