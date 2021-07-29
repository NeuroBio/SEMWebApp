window.JS = {

    showPrompt: function (message) {

    return prompt(message, 'Type anything here');

  },

  birdMatrixCreate: function(age) {
    var node = document.getElementById('BirdMatrix');
    while (node.hasChildNodes()) {
      node.removeChild(node.lastChild);
    }
    var rows=20;
    var cols=20;
    //<img src='/SEMWebApp/release/SEMWebApp/dist/Images/egg.png'>
    var imagenames = ["","<img src='/SEMWebApp/release/SEMWebApp/dist/Images/Chick.png'>", "<img src='/SEMWebApp/release/SEMWebApp/dist/Images/AdultFlip.png'>"];
    var tr;
    for(let i=0;i<rows;i++){
      tr = document.createElement('tr');
      document.getElementById('BirdMatrix').appendChild(tr);
      for(let j=0;j<cols;j++){
        var td = document.createElement('td');
        td.width = "30px";
        td.align = "center";
        if(age[i+j*cols]==0){
          td.innerHTML = imagenames[0];
        }else if(age[i+j*cols]==1){
          td.innerHTML = imagenames[1];
        }else{
          td.innerHTML = imagenames[2];
        }

        tr.appendChild(td);
      }
    }
    document.getElementById('BirdMatrix').rules = "all"
    document.getElementById('BirdMatrix').style.border = "1px solid #000"
    document.getElementById('BirdMatrix').style.width = "560px"
    document.getElementById('BirdMatrix').style.height = "560px"
  },

  birdMatrixUpdate: function(age, color) {
    var node = document.getElementById('BirdMatrix');
    while (node.hasChildNodes()) {
      node.removeChild(node.lastChild);
    }

    var rows=20;
    var cols=20;
    var imagenames = ["<img src='/SEMWebApp/release/SEMWebApp/dist/Images/egg.png'>","<img src='/SEMWebApp/release/SEMWebApp/dist/Images/Chick.png'>", "<img src='/SEMWebApp/release/SEMWebApp/dist/Images/AdultFlip.png'>"];
    //var tr;
    for(let i=0;i<rows;i++){
      tr = document.createElement('tr');
      document.getElementById('BirdMatrix').appendChild(tr);
      for(let j=0;j<cols;j++){
        var td = document.createElement('td');
        td.width = "30px";
        td.align = "center";
        td.style.backgroundColor = color[i+j*cols];
        if(age[i+j*cols]==0){
          td.innerHTML = imagenames[0];
        }else if(age[i+j*cols]==1){
          td.innerHTML = imagenames[1];
        }else{
          td.innerHTML = imagenames[2];
        }

        tr.appendChild(td);
      }
    }
  },

  birdMatrixColor: function(color) {
    var rows=20;
    var cols=20;
    var count=0;
    for(let i=0;i<rows;i++){
      for(let j=0;j<cols;j++){
        document.getElementById('BirdMatrix')[count].style.backgroundColor=color[i+j*cols];
        count += 1;
      }
    }
  }

};