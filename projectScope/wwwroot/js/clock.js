
// Code By Webdevtrick ( https://webdevtrick.com )
function se(){


    setTime();
    setInterval(setTime, 1000);



}
function setTime() {
    const secondline = $('.line-second');
    const minuteline = $('.line-minute');
    const hourline = $('.line-hour');



    let rotations = [0, 0, 0] // [second, minutes, hours]
    const now = new Date();

    const seconds = now.getSeconds();
    const minutes = now.getMinutes();
    const hours = now.getHours() % 12;
    const timer = now.getHours();




    if (seconds === 0) {
        rotations[0]++;
    }

    if (minutes === 0 && seconds === 0) {
        rotations[1]++;
    }

    if (hours === 0 && minutes === 0 && seconds === 0) {
        rotations[2]++;
    }

    const secondsDeg = (seconds / 60 * 360) + (rotations[0] * 360);
    const minutesDeg = (minutes / 60 * 360) + (rotations[1] * 360);
    const hoursDeg = (hours / 12 * 360) + (minutes / 60 * 30) + (rotations[2] * 360);

    secondline[0].style.transform = `rotate(${secondsDeg}deg)`;
    minuteline[0].style.transform = `rotate(${minutesDeg}deg)`;
    hourline[0].style.transform = `rotate(${hoursDeg - 30}deg)`;

    secondline[1].style.transform = `rotate(${secondsDeg}deg)`;
    minuteline[1].style.transform = `rotate(${minutesDeg}deg)`;
    hourline[1].style.transform = `rotate(${hoursDeg - 60}deg)`;

    secondline[2].style.transform = `rotate(${secondsDeg}deg)`;
    minuteline[2].style.transform = `rotate(${minutesDeg}deg)`;
    hourline[2].style.transform = `rotate(${hoursDeg - 150}deg)`;


    secondline[3].style.transform = `rotate(${secondsDeg}deg)`;
    minuteline[3].style.transform = `rotate(${minutesDeg}deg)`;
    hourline[3].style.transform = `rotate(${hoursDeg + 150}deg)`;

    secondline[4].style.transform = `rotate(${secondsDeg}deg)`;
    minuteline[4].style.transform = `rotate(${minutesDeg + 180}deg)`;
    hourline[4].style.transform = `rotate(${hoursDeg + 240}deg)`;


}