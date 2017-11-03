$(document).ready(function () {
    $(document).on('click', '.removeNum', function (e) {
        e.preventDefault();
        var removedNum = $(this).attr("removedNum");
        var allNumbers = $("input[name=numbers]").val();
        var allNumArray = allNumbers.split(',');
        allNumArray = jQuery.grep(allNumArray, function (value) {
            return value != removedNum;
        });
        allNumbers = allNumArray.join(",");
        $('.inputHidden').remove();
        $('#myForm').append("<input type='hidden' name='numbers' value='" + allNumbers + "' class='inputHidden'/>");
        var totalNumbers = $("#totalNumbers p").text();
        totalNumbers = totalNumbers - 1;
        $("#totalNumbers p").html(totalNumbers);
        var alreadyExisted = $("#alreadyExisted p").text();
        var isExisted = $(this).attr("isExist");
        if (isExisted == true) {
            alreadyExisted = alreadyExisted - 1;
            $("div#alreadyExisted p").html(alreadyExisted);
        }
        $(this).closest("tr").remove();
    });
})