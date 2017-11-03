$(document).ready(function () {
    var seriesId = $("input[name=seriesId]").val();
    var moveLeft = 20;
    var moveDown = 10;
    var url = "&seriesId=" + seriesId + "&matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&classificationString=" + $("#classificationString").val()
                + "&statusString=" + $("#statusString").val()
                + "&relatedPoolsOperator=" + $("#relatedPoolsOperator").val() + "&relatedPoolsValue=" + $("#relatedPoolsValue").val()
                + "&numberPriceOperator=" + $("#numberPriceOperator").val() + "&numberPriceValue=" + $("#numberPriceValue").val()
                + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
                + "&";
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto: false,
        url: "/Series/seriesNumbersSearchResultF?" + url 
    });
    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/Series/seriesNumbersSearchResultF?" + url
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/Series/seriesNumbersSearchResultF?" + url
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
                }
            });
        });
        $(document).click(null, function () {
            $('div#relatedPools_popUp').html('');
            $('div#relatedPools_popUp').hide();
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
    $(document).on('click', '#Cancel', function (e) {
        //$("#Cancel").on('click', function (e) {        
        e.preventDefault();
        var seriesId = $("input[name=seriesId]").val();
        location.href ="/Series/seriesNumbersSearchResult?" + url 
    });
    $(document).on('click', '#Release', function (e) {
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
        $("#myForm").append("<input type = 'hidden' name='fromSearch' value='yes' class='hiddenInput' />");
        $("#myForm").submit();
    });
})