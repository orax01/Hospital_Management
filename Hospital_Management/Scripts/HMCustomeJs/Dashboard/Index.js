$(document).ready(function () {
    $('#btnAdd').click(function () {
        debugger;

        //$('#outDoorId').prop("readonly", true);

        return;
        var outDoor = $('#outDoorId').val();
        outDoor == "" ? $('#outDoorId').addClass('is-invalid') : $('#outDoorId').removeClass('is-invalid');


        $("divTable").hide();
        divTable 
    });

});