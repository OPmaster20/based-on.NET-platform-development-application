function feedback(){
    var v1 = document.forms["user"]["phone"].value;
    var v2 = document.forms["user"]["name"].value;

    if((v1 == null || v1 == "") && (v2 == null || v2 == "")){
        alert("Incomplete information submitted!");
    }else{
        alert("Submitt successed !")
    }   
}


function check1(){
    var z = document.getElementsByName('female');
    var j = document.getElementsByName('male');
    for(var i = 0; i < j.length; i++){
        if(j[i].checked){
            z[i].checked = false;
        }
   
    }
}

function check2(){
    var z = document.getElementsByName('female');
    var j = document.getElementsByName('male');
    for(var i = 0; i < j.length; i++){
        if(z[i].checked){
            j[i].checked = false;
        }
    }
}