//Interrupts code for X miliseconds
function sleep(milliseconds) 
{
    const date = Date.now();
    let currentDate = null;
    do {
            currentDate = Date.now();
       } 
    while (currentDate - date < milliseconds);
  }

//get transition end browser based
function GetTransitionEnd() {
    var transitions = {
        //the different browsers' events
        transition: "transitionend",
        OTransition: "oTransitionEnd",
        MozTransition: "trnasitionend",
        WebkitTransform: "webkitTransitionEnd",
    };
    let bodyStyle = document.body.style;
    for (let transition in transitions) {
        if (bodyStyle[transition] != undefined) {
            return transitions[transition];
        }
    }
}
