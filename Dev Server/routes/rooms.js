const express = require('express');
const router = express.Router();

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