$(document).ready(function () {    
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto: false,
        url: "/Series/seriesListF?",
    });


    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/Series/seriesListF?",
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
        var seriesId = $(this).attr("series_id");
        $.ajax({
            url: "/Pools/getrelatedSeriesPools",
            type: "GET",
            data: { clickedSeries: seriesId },
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
            var seriesId = $(this).attr("series_id");
            $.ajax({
                url: "/Pools/getrelatedSeriesPools",
                type: "GET",
                data: { clickedSeries: seriesId },
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
    $('#exportSelected').on('click', function (e) {
        e.preventDefault();
        var series = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            series.push($(this).attr("id"));
        });
        var count = series.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any series",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $(".hiddenInput").remove();
            $("#myForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='selectedSeries' value='" + series + "' class='hiddenInput'/>");            
            $("#myForm").submit();
        }
    });
    $('#exportAll').on('click', function (e) {
        e.preventDefault();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");        
        $("#myForm").submit();
    });
})