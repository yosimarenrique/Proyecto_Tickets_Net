
function validar() {
    var nombre = $("#nombre").val();
    
    var ubicacion = $("#ubicacion").val();
    var telefono = $("#telefono").val();
    var descripcion = $("#descripcion").val();
   
    if ((nombre == "") || (ubicacion == "") || (telefono == "") || (descripcion == "")) {
      
        alert("Todos los campos son requeridos...!!!");
       
    }else{
        enviaremail();
    }
    
   // ipreventSubmit();
}

function cerrarmensaje() {
    $("#mensaje").css("display", "none");
}
function enviaremail() {

    $.ajax({
        url: urlEnvia,
        type: 'POST',
        data: { nombre: $("#nombre").val(), ubicacion: $("#ubicacion").val(), telefono: $("#telefono").val(), descripcion: $("#descripcion").val() },
        success: function (data) {
            if (data == "1") {
                $("#men").text("¡Bien hecho! Correo enviado Exitosamente");
                $("#mensaje").css("display", "block");
                $("#mensaje").removeClass("alert-danger");
                $("#mensaje").addClass("alert-success");
                $("#nombre").val("");
                $("#ubicacion").val("");
                $("#telefono").val("");
                $("#descripcion").val("");
                $("#cuerpo").css("display", "none");
            }
        },
        error: function () {
            $("#men").text("Error al enviar correo...!");
            $("#mensaje").removeClass("alert-success");
            $("#mensaje").addClass("alert-danger");
            $("#mensaje").css("display", "block");
            $("#cuerpo").css("display", "none");
        }

    });
};

function salir() {
    $("#mensaje").css("display", "none");
    $("#cuerpo").css("display", "block");
}

