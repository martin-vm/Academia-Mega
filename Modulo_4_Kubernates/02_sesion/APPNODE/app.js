const express = require('express');

const app = express();

const PORT = process.env.PORT || 3000;

app.get('/', (req, res) => {
    res.send("Martín Eduardo Villaseñor Merino, Saludos desde Docker!")
});

app.listen(PORT, () => {
    console.log(`Servidor de node escuchando en el puerto ${PORT}`)
})