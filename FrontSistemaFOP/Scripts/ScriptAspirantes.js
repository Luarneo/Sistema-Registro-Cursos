$(document).ready(function () {
    $('#TablaAspirantes').DataTable(
        //{
        //    language: {
        //        url: '/Scripts/spanish.json'
        //    }
        //}
    );

    $("#NvoAspirante").click(function () {
                
        $("#contenidoNuevoAspirante").empty();
        $.ajax({
            url: '/Aspirantes/NuevoAspirante',
            type: 'GET',
            dataType: 'html'
        }).done(function (data) {
            $("#contenidoNuevoAspirante").html(data);
        });
        $("#NuevoAspirante").modal("show");
    });

    //Guardar Nuevo Aspirante
    $("#contenidoNuevoAspirante").on("click", "#BtnGuardarAspirante", function () {


        $("#ValidNombre").html("Campo requerido");

        var NumeroEmpleado = $("#NumeroEmpleado").val();
        var Nombre = $("#Nombre").val();
        var ApellidoPaterno = $("#ApellidoPaterno").val();
        var ApellidoMaterno = $("#ApellidoMaterno").val();
        var EstatusAspirante = $("#Estatus").prop("checked"); 


        //alert(NumeroEmpleado + " " + Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno + " " + EstatusAspirante );

        //if (EstadoSeleccionado != "" && IdMunicipioSeleccionado != "" && NombreIngresado != "") {
        $.ajax({
            url: '/Aspirantes/GuardarNuevoAspirante',
            type: 'POST',
            data: {
                NumeroEmpleado: NumeroEmpleado,
                Nombre: Nombre,
                ApellidoPaterno: ApellidoPaterno,
                ApellidoMaterno: ApellidoMaterno,
                Estatus: EstatusAspirante
            },
            dataType: 'json'
        });
            //    .done(function (result) {
            //    $("#NuevaUbicacion .close").click()
            //    if (typeof result[0] != 'undefined' && typeof result[1] != 'undefined') {
            //        $("#AlertaDiv").append('<div class="alert alert-dismissible alert-' + result[0] + '"><button class="close" type="button" data-dismiss="alert">&times;</button><strong>' + result[1] + '</strong> </div>');

            //    }
            //});
        //}
        //else {
        //    if (EstadoSeleccionado == "") {
        //        $("#ValidEstado").html("Campo requerido");
        //    }
        //    if (IdMunicipioSeleccionado == "") {
        //        $("#ValidMunicipios").html("Campo requerido");
        //    }
        //    if (NombreIngresado == "") {
        //        $("#ValidNombre").html("Campo requerido");
        //    }
        //}



    });

});