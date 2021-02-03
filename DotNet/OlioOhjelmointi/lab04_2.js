
const generateRandom = () => Math.floor(Math.random() * 3 ) + 1

const AMOUNT_OF_SLOTS = 3

let values = []


for (let i=0; i < AMOUNT_OF_SLOTS; i++) {
    values.push(generateRandom())
}

function funkkari(randomArvo) {
    document.write(`<img src="http://`) 
}

values.forEach(randomArvo => document.write(`<img src="http://koti.tamk.fi/`) )

let text = values.every(item => item === values[0]) ? "won" : "lost"
document.write(text)


if (rand1 === 1)
{
    
}

if (rand1 === rand2 && rand2 === rand3) {
    document.write("WON!");
} 
else {
    document.write("Lost!");
}
