$(document).ready(function () {    
    var moveLeft = -50;
    var moveDown = -40;
    $(document).on('click', '#edit_pool', function (e) {
        e.preventDefault();
        var poolId = $('#edit_pool').attr('poolId');
        $('div#pool_option').html('');
        $('div#pool_option').toggle();
        //$('div#pool_option').css('top', e.pageY + moveDown);
        //$('div#pool_option').css('left', e.pageX + moveLeft);
        $('div#pool_option').append('<table>'
                        + "<tr><td><a href='/Pools/editPool?poolId=" + poolId + "&type=NORMAL'>" + "Edit Pool Info" + "</a></td></tr>"
                        + "<tr><td><a href='#' id='delete' poolId='" + poolId + "'>" + "Delete Pool" + "</a></td></tr>"
                        + '</table>');
    });
    $(document).on('click', '#delete', function (e) {
        e.preventDefault();
        var poolId = $('#delete').attr('poolId');
        $.msgBox({
            title: 'Delete Pool ',
            content: 'Are You Sure you want to delete this pool',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/Pools/deletePool",
                        type: "POST",
                        data: { poolId: poolId },
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
                                            location.href = "/pools/getNormalPoolsList";
                                    }
                                })
                            },
                        complete: function () {
                            $('body').removeClass('wait');
                        }
                    });
                }
            }
        });
    });
});