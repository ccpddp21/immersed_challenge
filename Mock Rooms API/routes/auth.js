const express = require('express');
const router = express.Router();

const authTable = require('../payload-templates/user-profiles.json');

let authenticate = (username, password) => {
    for (var i = 0; i < authTable.users.length; i++)
    {
        if (username == authTable.users[i].username && password == authTable.users[i].password)
        {
            return authTable.users[i].profileData;
        }
    }
    return {};
};

router.get('/login', (req, res) => {
    let payload = authenticate(req.query.username, req.query.password);
    res.send(payload); 
});

module.exports = router;