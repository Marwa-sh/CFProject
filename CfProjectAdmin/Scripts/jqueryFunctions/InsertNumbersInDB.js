$(document).ready(function () {
    $(document).find('[type=text]').keyup(function (e) {  
        if (e.keyCode == 13)
        {
            document.getElementById('addNumbers').click();
        }
    })
    $("#addNumbers").on('click', function (e) {
        e.preventDefault();        
        var num = $("input[name=numFromUser]").val();
        $("input[name=numFromUser]").html('');
        var allNumbers = $("input[name=allNumbers]").val();
        var existedNumbers = $("input[name=existedNumbers]").val();
        var totalNumbers = $("#totalNumbers p").text();
        var alreadyExisted = $("#alreadyExisted p").text();
        if (allNumbers.indexOf(num) >= 0 || existedNumbers.indexOf(num) >= 0) {
            $(".message").remove();
            $("div#userInput").append('<p class="message">you already entered this number </p>');
        }
        else {
            $.ajax({
                url: "/Numbers/AddNumbersF",
                type: "POST",
                data: { newNumber: num, totalNumbers: totalNumbers, alreadyExisted: alreadyExisted },
                dataType: "json",
                traditional: true,
                cache: false,
                async: true,
                success: function (data) {
                    if (data.isValid) {
                        $("div#totalNumbers p").html(data.totalNumbers);
                        $("div#alreadyExisted p").html(data.alreadyExisted);
                        $("#table-container").append(data.content);
                        $(".message").remove();
                        if (!data.isExist) {
                            if (allNumbers != "") {
                                if (allNumbers.indexOf(num) < 0)
                                    allNumbers = allNumbers + "," + num;
                            }
                            else {
                                allNumbers = num;
                            }
                            $('.inputHidden').remove();
                            $('#myForm').append("<input type='hidden' name='allNumbers' value='" + allNumbers + "' class='inputHidden'/>");
                            $('#myForm').append("<input type='hidden' name='existedNumbers' value='" + existedNumbers + "' class='inputHidden'/>");
                        }
                        else
                        {
                            if (existedNumbers != "") {                                
                                    existedNumbers = existedNumbers + "," + num;
                            }
                            else 
                                existedNumbers = num;
                            $('.inputHidden').remove();
                            $('#myForm').append("<input type='hidden' name='allNumbers' value='" + allNumbers + "' class='inputHidden'/>");
                            $('#myForm').append("<input type='hidden' name='existedNumbers' value='" + existedNumbers + "' class='inputHidden'/>");
                        }
                        //$("#message").html('');
                    }
                    else {
                        $(".message").remove();
                        $("div#userInput").append('<p class="message">invalid input, only numbers with 8 digit </p>');
                    }
                }
            });
        }
    });
    $(document).on('click', '.removeNum' , function(e){
        e.preventDefault();
        var removedNum = $(this).attr("removedNum");
        var allNumbers = $("input[name=allNumbers]").val();
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
        if(isExisted)        
        {
            alreadyExisted = alreadyExisted - 1;
            $("div#alreadyExisted p").html(alreadyExisted);
        }
        $(this).closest("tr").remove();
    });
})
//if (allNumbers != "")
//{
//    if (allNumbers.indexOf(num) >= 0) {
//        $("div#userInput").append('<p id="message">You already entered this number</p>');
//        $("div#totalNumbers p").html(data.totalNumbers - 1);
//        $("div#alreadyExisted p").html(data.alreadyExisted );
//    }
//    else {
//        $("div#totalNumbers p").html(data.totalNumbers);
//        $("div#alreadyExisted p").html(data.alreadyExisted);
//        $("#table-container").append(data.content);
//    }
//}
//else
//    $("#table-container").append(data.content);