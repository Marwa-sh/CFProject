$(window).load(function () {
    var moveLeft = 20;
    var moveDown = 10;
    var serieID = $("input[name=serieID]").attr("value");
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedSeries/getFreeSerieDetailsF?serieID=" + serieID + "&",
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedSeries/getFreeSerieDetailsF?serieID=" + serieID + "&",
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedSeries/getFreeSerieDetailsF?serieID=" + serieID + "&",
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

    $(document).on('click', '#exportAllNumbers', function (e) {
        e.preventDefault();
        $("form").submit();
    });

    $(document).on('click', '.relatedPools', function (e) {
        e.preventDefault();
        var serieId = $(this).attr("number_id");
        $.ajax({
            url: "/Pools/getrelatedSeriesPools",
            type: "GET",
            data: { clickedSeries: serieId },
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                if (data.length != 0) {
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                                      .css('top', e.pageY + moveDown)
                                      .css('left', e.pageX + moveLeft)
                                      .append('<table>' + data + '</table>')
                                      .appendTo('body');
                }
                else {
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                          .css('top', e.pageY + moveDown)
                          .css('left', e.pageX + moveLeft)
                          .append('<table>No Pools</table>')
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