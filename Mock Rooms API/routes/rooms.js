const express = require('express');
const router = express.Router();

const rooms = require('../payload-templates/room-details.json');

let activeServerIds = [];

let getRegisteredRooms = (roomIds) => {
    let roomList = []
    for (var i = 0; i < rooms.rooms.length; i++)
    {
        if (roomIds.includes(rooms.rooms[i].roomId))
        {
            console.log(rooms.rooms[i]);
            roomList.push(rooms.rooms[i]);
        }
    }
    return roomList;
};

router.get('/public', (req, res) => {
    res.send(rooms);
});

router.get('/registered', (req, res) => {
    res.send(getRegisteredRooms(req.query.roomIds));
});

router.get('activate', (req, res) => {
    res.send(true);
});

router.get('/join', (req, res) => {
    res.send(true);
});

router.get('/kick', (req, res) => {
    res.send(true);
});

router.get('/invite', (req, res) => {
    res.send(true);
});

router.get('/leave', (req, res) => {
    res.send(true);
});

module.exports = router;