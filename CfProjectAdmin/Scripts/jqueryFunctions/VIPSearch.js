$(window).load(function () {    
    var pickedNumbers = 0;
    var next = 0;
    $("#Number").keydown(function (event) {
        // Allow: backspace, delete, tab, escape and enter
        if ($.inArray(event.keyCode, [46, 8, 9, 27, 13, 110]) !== -1 ||
            // Allow: Ctrl+A, Command+A
        (event.keyCode === 65 && (event.ctrlKey === true || event.metaKey === true)) ||
            // Allow: home, end, left, right, down, up
        (event.keyCode >= 35 && event.keyCode <= 40)) {
            // let it happen, don't do anything

        }
        else {
            // Ensure that it is a number and stop the keypress
            if (!((event.keyCode >= 48 && event.keyCode <= 57) || (event.keyCode >= 96 && event.keyCode <= 105))) {
                event.preventDefault();
            }
        }
    });

    $(document).on('click', '#searchbtn', function (e) {
        pickedNumbers = 0;
        next = 0;
        $("#picked-numbers-container").html("");
        $('div#reserve').hide();

        var urlSearch = "/VIPReservation/searchNumbersReservation?start=0";        
        var matchtype = "";
        $('input[name=numberByFilter]:checked').each(function () {
            matchtype = $(this).attr("value");
        });
        var num = $("#Number").val();
        var patern = $("#Pattern").val();
        var classefication = $("#classLable").val();
        var from = -1;
        var to = -1;
        var setting = $("#sysSettings").val();
        if (setting == 1) {
            from = $("#from").val();
            to = $("#to").val();
        }
        if (num == "" && patern == "" && classefication == "" && from <= 0 && to <= 0) {
            $.msgBox({
                title: 'WARNING',
                content: "Please insert one parameter at least.",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('body').addClass('wait');
            $.ajax({
                url: urlSearch,
                data: { number: num, pattern: patern, classif: classefication, priceFrom: from, priceTo: to, TempNumber: "", matchType: matchtype, pickedNumbers: pickedNumbers },
                type: "GET",
                dataType: "json",
                cache: false,
                async: true,
                success: function (data) {
                    if (data.status) {
                        $("#numbers-container").html('');
                        $(data.content).hide().appendTo($("#numbers-container")).fadeIn(1000);
                        if (data.message == "Next") {
                            $('div#next').show();
                            $("#prevbtn").hide('');
                            $("#nextbtn").show('');
                        }
                        else {
                            $("#nextbtn").hide();
                        }
                        $(document).trigger("contentChanged");
                    } else {
                        $.msgBox({
                            title: 'WARNING',
                            content: data.message,
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                        })
                    }
                },
                error: function (data) {
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }        
    });

    $(document).on('change', ':checkbox', function () {
        var checkedNum = [];
        var searchRows = [];            
        
        if (pickedNumbers == 0) {
            $("#picked-numbers-container").html("");
            var header = $("#numbers-container tr").first().html();
            $("#picked-numbers-container").append("<tr id='tableHeader'>" + header + "</tr>");
            $("#picked-numbers-container").find(':checkbox').closest('th').html('');            
        }
        
            
            $("#SearchAndPickResult").find(':checked').each(function () {
                var searchTR = $(this).closest('tr');
                if (searchTR.attr('id') != 'tableHeader') {
                    checkedNum.push(searchTR.attr('id'));
                    searchRows.push(searchTR.html());
                }
            });
            var i=0;
            while (i < checkedNum.length) {
                var existnum = 0;
                $("#picked-numbers-container").find('.number-id').each(function () {
                    var pickTR = $(this).closest('tr');
                    if (pickTR.attr('id') != 'tableHeader' && pickTR.attr('id') == checkedNum[i])
                        existnum = 1;
                });
                if (existnum == 0) {
                    var numberId = checkedNum[i];
                    var row = searchRows[i];
                    $("#picked-numbers-container").append("<tr class='number-id' id='" + numberId + "'>" + row + "</tr>");
                    pickedNumbers++;
                }
                i++;
            }
            

            
            var pickHeader = $("#picked-numbers-container tr").first().attr('id');
            pickedNumbers = 0;
            $("#picked-numbers-container").find('.number-id').each(function () {
                var pickTR = $(this).closest('tr');                
                if (pickTR.attr('id') != pickHeader)
                    pickedNumbers++;
            });

            $("#picked-numbers-container").find(":checkbox").each(function () {
                $(this).replaceWith('<i class="fa fa-minus-circle fa-2x delete-choosed-number" title="Delete" />');
            });

        if (pickedNumbers > 0) {
            $('div#reserve').show();
        }
        else {
            $("#picked-numbers-container").html("");
            $('div#reserve').hide();
        }
    });
    $(document).on('click', '.delete-choosed-number', function () {
        var numberId = $(this).closest('tr').attr("id");
        var removedRow = $("#SearchAndPickResult").find('.number-id[id=' + numberId + ']').find('input[type="checkbox"]').attr('checked', false);
        $(this).closest('tr').remove();
        pickedNumbers--;
        var numbersList = [];
        $('input[name=checkedNumbers]').each(function () {
            numbersList.push($(this).attr("value"));
        });
        $('body').addClass('wait');
        $.ajax({
            url: "/VIPReservation/ReleasePickedNumbers",
            data: { numberID: numberId, numberIDs: numbersList.toString() },
            type: "GET",
            dataType: "json",
            cache: false,
            async: true,
            success: function (data) {
                if (pickedNumbers == 0) {
                    $("#picked-numbers-container").html("");
                    $('div#reserve').hide();
                }
            },
            error: function (data) {
            },
            complete: function () {
                $('body').removeClass('wait');
            }
        });
    });

    $(document).on('click', '#nextbtn', function (e) {
        next = 1;
        var urlSearch = "/VIPReservation/searchNumbersReservation?next=0";
        var numbersList = [];
        $('input[name=checkedNumbers]:not(:checked)').each(function () {
            numbersList.push($(this).attr("value"));
        });        
        var matchtype = "";
        $('input[name=numberByFilter]:checked').each(function () {
            matchtype = $(this).attr("value");
        });
        var num = $("#Number").val();
        var patern = $("#Pattern").val();
        var classefication = $("#classLable").val();
        var from = -1;
        var to = -1;
        var setting = $("#sysSettings").val();
        if (setting == 1) {
            from = $("#from").val();
            to = $("#to").val();
        }
        var numChecked = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numChecked.push($(this).attr("value"));
        });
        $('body').addClass('wait');
        $.ajax({
            url: urlSearch,
            data: { number: num, pattern: patern, classif: classefication, priceFrom: from, priceTo: to, TempNumber: numbersList.toString(), matchType: matchtype, pickedNumbers: pickedNumbers },
            type: "GET",
            dataType: "json",
            cache: false,
            async: true,
            success: function (data) {
                if (data.status) {                    
                    if (data.message == "Next") {
                        $("#numbers-container").html('');
                        $(data.content).hide().appendTo($("#numbers-container")).fadeIn(1000);
                        $('div#next').show();
                        $("#nextbtn").show();
                        $("#prevbtn").show();
                    }
                    else {
                        $("#nextbtn").hide();
                    }
                    $(document).trigger("contentChanged");
                } else {
                    $.msgBox({
                        title: 'WARNING',
                        content: data.message,
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                    })
                }
            },
            error: function (data) {
            },
            complete: function () {
                $('body').removeClass('wait');
            }
        });        
    });

    $(document).on('click', '#prevbtn', function (e) {
        var urlSearch = "/VIPReservation/searchNumbersReservation?prev=0";
        var numbersList = [];
        $('input[name=checkedNumbers]:not(:checked)').each(function () {
            numbersList.push($(this).attr("value"));
        });
        var matchtype = "";
        $('input[name=numberByFilter]:checked').each(function () {
            matchtype = $(this).attr("value");
        });
        var num = $("#Number").val();
        var patern = $("#Pattern").val();
        var classefication = $("#classLable").val();
        var from = -1;
        var to = -1;
        var setting = $("#sysSettings").val();
        if (setting == 1) {
            from = $("#from").val();
            to = $("#to").val();
        }       
        $('body').addClass('wait');
        $.ajax({
            url: urlSearch,
            data: { number: num, pattern: patern, classif: classefication, priceFrom: from, priceTo: to, TempNumber: numbersList.toString(), matchType: matchtype, pickedNumbers: pickedNumbers },
            type: "GET",
            dataType: "json",
            cache: false,
            async: true,
            success: function (data) {
                if (data.status) {
                    $("#numbers-container").html('');
                    $(data.content).hide().appendTo($("#numbers-container")).fadeIn(1000);
                    if (data.message == "Next") {
                        $('div#next').show();
                        $("#nextbtn").show();
                        $("#prevbtn").show();
                    }
                    else {
                        $("#nextbtn").show();
                        $("#prevbtn").hide();
                    }
                    $(document).trigger("contentChanged");
                } else {
                    $.msgBox({
                        title: 'WARNING',
                        content: data.message,
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                    })
                }
            },
            error: function (data) {
            },
            complete: function () {
                $('body').removeClass('wait');
            }
        });
    });

    $(document).on('click', '#reservebtn', function (e) {
        var urlSearch = "/VIPReservation/ReserveButton";
        var List = [];
        $("#picked-numbers-container").find('.number-id').each(function () {
            List.push($(this).attr("id"));
        });
        if (List.length == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any number.",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            //var numbersList = [];
            //$('input[name=checkedNumbers]:not(:checked)').each(function () {
            //    numbersList.push($(this).attr("value"));
            //});
            $('body').addClass('wait');
            $.ajax({
                url: urlSearch,
                data: { pickedNums: List.toString() },
                type: "GET",
                dataType: "json",
                cache: false,
                async: true,
                success: function (data) {
                    if (data) {
                        location.href = "/VIPReservation/NewReservationRequest";
                    }
                },
                error: function (data) {
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }        
    });

});