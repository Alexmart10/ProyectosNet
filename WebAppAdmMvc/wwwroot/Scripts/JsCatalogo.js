let tablaData;

$(document).ready(function () {

    $('#dgCat').bootstrapTable({
        
    });
    LoadCatalogo();


   
});


function LoadCatalogo() {

    $.ajax({
        url: '/Catalogo/CargarLista', 
       data: '',
        type: 'GET',
        async: false,
        //contentType: "application/json; charset=utf-8",
        success: function (response) {
            $('#dgCat').bootstrapTable("load", response.data);
        },
        error: function (XMLHttpRequest, success, errorThrown) {
            
            alert("Error", "NovaSys", XMLHttpRequest.responseText)
        }
    });
  
};


