$(document).ready(function () {    
    var moveLeft = -50;
    var moveDown = -40;
    var seriesId = $("input[name=seriesId]").val();
    var isPooled = $("input[name=isPooled]").val();
    var seriesStatus = $("input[name=seriesStatus]").val();
    
    var freeSeriesOption = '<table>'
            + "<tr><td><a href='#' id='delete' seriesId='" + seriesId + "'>Delete Series</a></td></tr>"
            + "<tr><td><a href='/Series/fragmentSeries?seriesId=" + seriesId + "'>Fragment Series</a></td></tr>"
                       + '</table>';
    var pooledSeriesOption = '<table>'
            + "<tr><td><a href='#' id='delete' seriesId='" + seriesId + "'>" + "Delete Series" + "</a></td></tr></table>";
    

    $(document).on('click', '#editSeries', function (e) {
        e.preventDefault();        
        $('div#pool_option').html('');
        $('div#pool_option').toggle();
        if (isPooled == 0 && seriesStatus == "AVAILABLE")
            $('div#pool_option').append(freeSeriesOption);
        else
            $('div#pool_option').append(pooledSeriesOption);
    });

    $(document).on('click', '#delete', function (e) {
        e.preventDefault();
       // var seriesId = $('#delete').attr('seriesId');
        $.msgBox({
            title: 'Delete Series ',
            content: 'Are You Sure you want to Delete  this Series?',
            type: "prompt",
            inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],           
            success: function (result) {
                if ($("input[name=password]").val() == "")
                    $.msgBox({
                        title: 'WARNING',
                        content: "Error Password",
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                        success: function (result) {
                            if (result == "OK")
                                location.reload();
                        }
                    })
                else {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Series/deleteSeries",
                            type: "POST",
                            data: { seriesId: seriesId },
                            dataType: "json",
                            traditional: true,
                            cache: false,
                            async: true,
                            success:
                                function (json) {
                                    $.msgBox({
                                        title: 'success msg',
                                        content: json,
                                        type: "success",
                                        opacity: 0.5,
                                        buttons: [{ value: "OK" }],
                                        success: function (result) {
                                            if (result == "OK")
                                                location.href = "/Series/SeriesList";
                                        }
                                    })
                                },
                            complete: function () {
                                $('body').removeClass('wait');
                            }
                        });
                    }
                }
            }
        });
    });
})