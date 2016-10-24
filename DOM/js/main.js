"use strict";

//--- Object sample
var person = {
    firstName: 'Jeffrey',
    middleName:'Efrain',
    lastName: 'Ferreiras',
    address: {
        street: '111 Orchard st.',
        town:'Bloomfield',
        state: 'New Jersey',
        zip: '07003'
    },
    eyecolor: 'brown',
    fullName: function (){
        return this.firstName + this.middleName + this.lastName;
    }
}

!function init()
{
    /*
     * Check to see if jQuery is loaded, if not loaded add to 'head' tag and fire
     * specified method on load.
     */
    if (!window.jQuery) {
        var jqueryScript = document.createElement('script');
        jqueryScript.type = 'text/javascript';
        jqueryScript.src = 'Scripts/jquery-3.1.1.js';
        jqueryScript.onload = jqueryFun;
        document.head.appendChild(jqueryScript);
    } else {
        jqueryFun();
    }
}();

function jqueryFun(){

    alert(window.jQuery === undefined);
}

function hexClockProgram()
{
    function init() {
        var tick = setInterval(function () { hexClock(time()) }, 1000);
        stopClick(clearInterval, tick);
        startClick(init);
    }

    function hexClock(time) {
        var color = '#' + time;
        document.body.bgColor = color;
        document.body.textContent = color;
        document.body.style.height = '100vh';
    }

    function time() {
        var date = new Date();
        var hours = date.getHours();
        var minutes = date.getMinutes();
        var seconds = date.getSeconds();

        var arr = [hours, minutes, seconds].map(function (num) {
            return num < 10 ? '0' + num : num.toString();
        });

        hours = arr[0];
        minutes = arr[1];
        seconds = arr[2];

        return hours + minutes + seconds;
    }

    function startClick(callback) {
        document.body.addEventListener('click', function (event) {
            callback();
        });
    }

    function stopClick(callback, name) {
        document.body.addEventListener('click', function (event) {
            callback(name);
        });
    }
}

function fullScreen(element) {
    var newElement = document.createElement(element);
    newElement.style.height = '100vh';
    document.body.appendChild(newElement);
    return newElement;
}

function input(inputType, element, callback) {
    element.addEventListener(inputType, function (event) {
        var x = event.clientX;
        var y = event.clientY;
        callback(element, x, y)
    });
}

function output(element, x, y)
{
    element.textContent = x + ', ' + y;
    element.style.backgroundColor = 'rgb(' + x + ',' + y + ',100)';
}

