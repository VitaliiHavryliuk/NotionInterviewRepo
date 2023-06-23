function SendRequest(num1, num2, res){
    var url = "http://localhost:32773/Add"

    fetch(url, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body:  JSON.stringify({Num1:num1, Num2:num2})
    })
    .then(response => response.json())
    .then(data => {
        if(data.code!= 200){
            console.log(data.code)
            res.innerHTML ="Error";
        }
        else{
            res.innerHTML = "Result="+data.result;
        }
    })
    .catch(error =>{
        console.log(error);
    });
}

function Add(){
        var input1 = document.getElementById("num1");
        var input2 = document.getElementById("num2");
        var res = document.getElementById('res');
        var num1 = input1.value;
        var num2 = input2.value;

        if(isNum(num1) && isNum(num2)){
            SendRequest(num1, num2, res)
        }
        else{
            res.innerHTML = "You have to enter numbers!"
        }
    }

function isNum(num){
    return !isNaN(num) && !isNaN(parseFloat(num));
}
