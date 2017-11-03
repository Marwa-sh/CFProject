$(document).ready(function () {
    var seriesId = $("input[name=seriesId]").val();
    var moveLeft = 20;
    var moveDown = 10;  
    //$().loadMore({
    //    button: $("#load-more"),
    //    container: $("#numbers-container"),
    //    auto: false,
    //    url: "/Series/SeriesNumbersF?seriesId=" + seriesId + "&",
    //});
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto: false,
        url: "/Series/SeriesNumbersF?seriesId=" + seriesId + "&",
    });
    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/Series/SeriesNumbersF?seriesId=" + seriesId + "&",
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/Series/SeriesNumbersF?seriesId=" + seriesId + "&",
    });
    $(document).on('click', '#sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-number:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-number:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#numbers-container tr").first().clone();
        $("#numbers-container").html("");
        $("#numbers-container").append(header);
        cloneCheckedRows.each(function () {
            $("#numbers-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#numbers-container").append($(this));
        });
    });
    $('.relatedPools').click(null, function (e) {
        var numberId = $(this).attr("number_Id");
        $.ajax({
            url: "/Pools/getRelatedSeriesNumberPools",
            type: "GET",
            data: { clickedNumber: numberId },
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                $('div#relatedPools_popUp').html('');
                if (data == null || data == "") {
                    $('div#relatedPools_popUp').show()
                                  .css('top', e.pageY + moveDown)
                                  .css('left', e.pageX + moveLeft)
                                  .append('No Pool')
                                  .appendTo('body');
                }
                else {
                    $('div#relatedPools_popUp').show()
                                     .css('top', e.pageY + moveDown)
                                     .css('left', e.pageX + moveLeft)
                                     .append('<table>' + data + '</table>')
                                     .appendTo('body');
                }
            },
            error: function (data) {
            }
        });
    });
    $(document).click(null, function () {
        $('div#relatedPools_popUp').html('');
        $('div#relatedPools_popUp').hide();
    });
    $(document).on('contentChanged', function () {
        $('.relatedPools').click(null, function (e) {
            var numberId = $(this).attr("number_Id");
            $.ajax({
                url: "/Pools/getRelatedSeriesNumberPools",
                type: "GET",
                data: { clickedNumber: numberId },
                dataType: "json",
                traditional: true,
                cache: false,
                async: true,
                success: function (data) {
                    $('div#relatedPools_popUp').html('');
                    if (data == null || data == "") {
                        $('div#relatedPools_popUp').show()
                                      .css('top', e.pageY + moveDown)
                                      .css('left', e.pageX + moveLeft)
                                      .append('No Pool')
                                      .appendTo('body');
                    }
                    else {
                        $('div#relatedPools_popUp').show()
                                         .css('top', e.pageY + moveDown)
                                         .css('left', e.pageX + moveLeft)
                                         .append('<table>' + data + '</table>')
                                         .appendTo('body');
                    }
                },
                error: function (data) {
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        });
        $(document).click(null, function () {
            $('div#relatedPools_popUp').html('');
            $('div#relatedPools_popUp').hide();
        });

    });
    $('#releaseSeriesFromReservationRequest').on('click', function () {
        $.msgBox({
            title: 'Release Series',
            content: 'Are You Sure you want to release this reserved series ',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/Series/releaseSeriesFromReservationRequest",
                        type: "POST",
                        data: { seriesId: seriesId },
                        dataType: "json",
                        traditional: true,
                        cache: false,
                        async: true,
                        success: function (data) {
                            if (data.status) {
                                $.msgBox({
                                    title: 'SUCCESS',
                                    content: data.message,
                                    opacity: 0.5,
                                    buttons: [{ value: "OK" }],
                                    success: function (result) {
                                        if (result == "OK")
                                            return true;
                                    }
                                });
                            } else {
                                $.msgBox({
                                    title: 'WARNING',
                                    content: data.message,
                                    opacity: 0.5,
                                    buttons: [{ value: "OK" }],
                                    success: function (result) {
                                        if (result == "OK")
                                            return true;
                                    }
                                });
                            }
                            location.reload();
                        },
                        complete: function () {
                            $('body').removeClass('wait');
                        }
                    });
                }
            }
        });
    });
    $('#releaseSelectedNumbers').on('click', function (e) {
        e.preventDefault();
       // var minSeriesLength = $("input[name=minSeriesLength]").val();
        var numbers = [];
      //  var numOrders = [];
        var checkedNumContent = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbers.push($(this).attr("id"));
            checkedNumContent.push($(this).closest("tr").find('#numberContent').attr('numberContent'));
        });
        var count = numbers.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any number",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
                success: function (result) {
                    if (result == "OK")
                        return true;
                }
            })
        }
        else {
            var seriesRange = $("input[name=seriesRange]").val();
            var seriesFirstContent = $("input[name=seriesFirstContent]").val();
            var seriesLastContent = $("input[name=seriesLastContent]").val();
            $.msgBox({
                title: 'Release Numbers',
                content: 'Are You Sure you want to release ' + count + ' number(s)? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Series/ReleaseSeriesNumbers",
                            type: "POST",
                            data: { seriesId: seriesId, selectedNumbersIds: numbers, checkedNumContent: checkedNumContent, seriesRange: seriesRange, seriesFirstContent: seriesFirstContent, seriesLastContent: seriesLastContent },
                            dataType: "json",
                            traditional: true,
                            cache: false,
                            async: true,
                            success: function (data) {
                                $('[todeleteattr=removedHtml]').remove();
                                $('#load-more').remove();
                                $('#myForm').html('');
                                $('#myForm').append("<br/>");
                                $('#myForm').append(data.totalSeries);
                                $('#myForm').append("<br/>");
                                $('#myForm').append(data.seriesRows);
                                $('#myForm').append("<br/>");
                                $('#myForm').append(data.totalReleasedNumbers);
                                $('#myForm').append("<br/>");
                                $('#myForm').append(data.numRows);
                                $('#myForm').append("<br/>");
                                $('#myForm').append(data.buttons);
                                $('#myForm').append("<input type='hidden' name='newSubSeries' value='" + data.newSubSeries + "'/>");
                                $('#myForm').append("<input type='hidden' name='releasedNum' value='" + data.releasedNum + "'/>");
                                //$('#myForm').append("<input type='hidden' name='seriesId' value='" + seriesId + "'/>");
                                $('#myForm').append("<input type='hidden' name='sourceRange' value='" + data.sourceRange + "'/>");
                            },
                            complete: function () {
                                $('body').removeClass('wait');
                            }
                        });
                    }
                }
            });
        }     
    });
            //var seriesNumsOrder = $("input[name=seriesNumsOrder]").val();
            //numOrders = seriesNumsOrder.split(',');

            //var SourceSeriesNumbersCount = $("input[name=SourceSeriesNumbersCount]").val();
            //var firstNum = numOrders[0];
            //var LastNum = numOrders[SourceSeriesNumbersCount - 1];
            //var lengthBetweenFirstNumAndSelectedNumAllowRelease = true;
            //for (var i = 0 ; i <= checkedNumOrder.length; i++) {
            //    var lengthBetweenFirstNumAndSelectedNum = Number(checkedNumOrder[i]) - Number(firstNum);
            //    if (lengthBetweenFirstNumAndSelectedNum < minSeriesLength && lengthBetweenFirstNumAndSelectedNum != 0)
            //        lengthBetweenFirstNumAndSelectedNumAllowRelease = false;
            //    if (!lengthBetweenFirstNumAndSelectedNumAllowRelease)
            //        break;
            //}
            //if (!lengthBetweenFirstNumAndSelectedNumAllowRelease) {
            //    $.msgBox({
            //        title: 'WARNING',
            //        content: "you must let atleast " + minSeriesLength + " numbers between first number in Series and released number",
            //        opacity: 0.5,
            //        buttons: [{ value: "OK" }],
            //        success: function (result) {
            //            if (result == "OK")
            //                return true;
            //        }
            //    });
            //}
            //else{
            //    var lengthBetweenLastNumAndSelectedNumAllowRelease = true;
            //    for (var i = 0 ; i <= checkedNumOrder.length; i++) {
            //        var lengthBetweenLastNumAndSelectedNum = Number(LastNum) - Number(checkedNumOrder[i]);
            //        if (lengthBetweenLastNumAndSelectedNum < minSeriesLength && lengthBetweenLastNumAndSelectedNum != 0)
            //            lengthBetweenLastNumAndSelectedNumAllowRelease = false;
            //        if (!lengthBetweenLastNumAndSelectedNumAllowRelease)
            //            break;
            //    }
            //    if (!lengthBetweenLastNumAndSelectedNumAllowRelease) {
            //        $.msgBox({
            //            title: 'WARNING',
            //            content: "you must let atleast " + minSeriesLength + " numbers between the released numbers and last series number",
            //            opacity: 0.5,
            //            buttons: [{ value: "OK" }],
            //            success: function (result) {
            //                if (result == "OK")
            //                    return true;
            //            }
            //        });
            //    }
            //    else{
            //        var lengthBetweenSelectedNumAllowRelease = true;
            //        for (var i = 0 ; i <= checkedNumOrder.length; i++) {
            //            for (var j = 0 ; j <= checkedNumOrder.length; j++) {
            //                if (Number(checkedNumOrder[i]) != Number(checkedNumOrder[j])) {
            //                    if (Number(checkedNumOrder[j]) != (Number(checkedNumOrder[i]) + 1)) {
            //                        var lengthBetweenSelectedNum = Number(checkedNumOrder[i]) - Number(checkedNumOrder[j]) -1;
            //                        if (lengthBetweenSelectedNum < minSeriesLength && lengthBetweenSelectedNum > 0 )
            //                            lengthBetweenSelectedNumAllowRelease = false;
            //                    }
            //                }
            //                if (!lengthBetweenSelectedNumAllowRelease)
            //                    break;
            //            }
            //            if (!lengthBetweenSelectedNumAllowRelease)
            //                break;
            //        }
            //        if (!lengthBetweenSelectedNumAllowRelease) {
            //            $.msgBox({
            //                title: 'WARNING',
            //                content: "you must let atleast " + minSeriesLength + " numbers between the released numbers",
            //                opacity: 0.5,
            //                buttons: [{ value: "OK" }],
            //                success: function (result) {
            //                    if (result == "OK")
            //                        return true;
            //                }
            //            });
            //        }
            //        else {                                               
                        //var uncheckedNumContent = [];
                        //for (var i = 0 ; i < numOrders.length; i++) {
                        //    var canAdded = true;
                        //    for (var j = 0 ; j < checkedNumOrder.length; j++) {
                        //        var n = numOrders[i];
                        //        var c = checkedNumOrder[j]
                        //        if (n == c)
                        //            canAdded = false;
                        //        if (!canAdded)
                        //            break;
                        //    }
                        //    if (canAdded)
                        //        uncheckedNumContent.push(numOrders[i]);
                        //}
    //                    var seriesRange = $("input[name=seriesRange]").val();
    //                    $.msgBox({
    //                        title: 'Release Numbers',
    //                        content: 'Are You Sure you want to release ' + count + ' number(s)? ',
    //                        type: "confirm",
    //                        opacity: 0.5,
    //                        buttons: [{ value: "Yes" }, { value: "No" }],
    //                        success: function (result) {
    //                            if (result == "Yes") {
    //                                $.ajax({
    //                                    url: "/Series/ReleaseSeriesNumbers",
    //                                    type: "POST",
    //                                    data: { seriesId: seriesId, selectedNumbersIds: numbers, uncheckedNumContent: uncheckedNumContent, seriesRange: seriesRange },
    //                                    dataType: "json",
    //                                    traditional: true,
    //                                    cache: false,
    //                                    async: true,
    //                                    success: function (data) {
    //                                        $('#removedHtml').remove();
    //                                        $('#load-more').remove();
    //                                        $('#myForm').html('');
    //                                        $('#myForm').append("<br/>");
    //                                        $('#myForm').append(data.totalSeries);
    //                                        $('#myForm').append("<br/>");
    //                                        $('#myForm').append(data.seriesRows);
    //                                        $('#myForm').append("<br/>");
    //                                        $('#myForm').append(data.totalReleasedNumbers);
    //                                        $('#myForm').append("<br/>");
    //                                        $('#myForm').append(data.numRows);
    //                                        $('#myForm').append("<br/>");
    //                                        $('#myForm').append(data.buttons);
    //                                        $('#myForm').append("<input type='hidden' name='subSeriesContent' value='"+data.subSeriesContent+"'/>");
    //                                        $('#myForm').append("<input type='hidden' name='releasedNum' value='" + data.releasedNum + "'/>");
    //                                        //$('#myForm').append("<input type='hidden' name='seriesId' value='" + seriesId + "'/>");
    //                                        $('#myForm').append("<input type='hidden' name='sourceRange' value='" + data.sourceRange + "'/>");                                            
    //                                    }
    //                                });
    //                            }
    //                        }
    //                    });
    //                }
    //        //    }
    //      //  }
    //      //  }       
    //});    
    $(document).on('click', '#Cancel', function (e) {
    //$("#Cancel").on('click', function (e) {        
        e.preventDefault();
        var seriesId = $("input[name=seriesId]").val();
        location.href = "/Series/SeriesNumbers?seriesId=" + seriesId;
        
        //$('#myForm').attr('action', "/SeriesNumbers?seriesId=" + seriesId).submit();
    });
    //$("#Release").on('click', function (e) {
    $(document).on('click', '#Release', function (e) {
        $('body').addClass('wait');
        e.preventDefault();
        var newSubSeries = $("input[name=newSubSeries]").val();
        var releasedNum = $("input[name=releasedNum]").val();
        var seriesId = $("input[name=seriesId]").val();
        var sourceRange = $("input[name=sourceRange]").val();
        $('body').addClass('wait');
        $.ajax({
            url: "/Series/releaseNumbersFromSeries",
            type: "POST",
            data: { seriesId: seriesId, newSubSeries: newSubSeries, releasedNum: releasedNum, seriesRange: sourceRange },
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function () {
                
                location.href = "/Series/SeriesList";
              //  $('body').removeClass('wait');

            },
              complete: function () {
                            $('body').removeClass('wait');

            }
        });

    });
    $('#exportSelectedNumbers').on('click', function (e) {
        e.preventDefault();
        var numbers = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbers.push($(this).attr("id"));
        });
        var count = numbers.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any number",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $(".hiddenInput").remove();
            $("#myForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='selectedNumbers' value='" + numbers + "' class='hiddenInput'/>");
            $("#myForm").submit();
        }
    });
    $('#exportAllNumbers').on('click', function (e) {
        e.preventDefault();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");        
        $("#myForm").submit();
    });
})