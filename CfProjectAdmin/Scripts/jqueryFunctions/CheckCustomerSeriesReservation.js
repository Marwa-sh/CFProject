$(document).ready(function () {
    var moveLeft = 20;
    var moveDown = 10;
    $(document).on('click', '#customer-resrvation-dialog', function () {
        var customerId = $("#customerId").val();
        showCustomerReservationDialog(customerId);
    });
    $(document).on('click', '#closeAndForward', function () {
        var url = $(this).attr('action-url');
        showDirectorTypeDialog(url);
    });
    $(document).on('click', '#closeAndApprove', function () {
        var url = $(this).attr('action-url');
        showCloseAndApproveDialog(url);
    });
    $(document).on('click', '#closeAndReject', function () {
        showRemarkDialog($(this).attr('action-url'));
    });
    if ($("#reservationMessage").val() != "") {
        var box = bootbox.dialog({
            size: 'small',
            title: "WARNING",
            message: $("#reservationMessage").val()
        });
    }
    $('[data-toggle="delete-confirmation"]').confirmation({
        container: 'body',
        onConfirm: function () {
            //ajax call
            $('body').addClass('wait');
            $.ajax({
                type: "POST",
                url: $(this).attr('ajax-url'),
                dataType: 'json',
                cache: false,
                async: true,
                success: function (data) {
                    if (data.Status && data.Url != null) {
                        location.href = data.Url;
                    }
                    if (!data.Status) {
                        $.msgBox({
                            type : "success",
                            title: 'Release Number',
                            content: data.message,
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK")
                                    location.reload();
                            }
                        })
                    }
                },
                error: function (data) {
                    //$.msg
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });
        }
    });

    //related pools
    $('.relatedPools').click(null, function (e) {
        var seriesId = $(this).attr("seriesId");
        $.ajax({
            url: "/AxiosSeries/getRelatedPools",
            type: "GET",
            data: { seriesId: seriesId },
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                $('div#relatedPools_popUp').html('');
                $('div#relatedPools_popUp').show()
                                  .css('top', e.pageY + moveDown)
                                  .css('left', e.pageX + moveLeft)
                                  .append('<table>' + data + '</table>')
                                  .appendTo('body');
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
            var seriesId = $(this).attr("seriesId");
            $.ajax({
                url: "/AxiosSeries/getRelatedPools",
                type: "GET",
                data: { seriesId: seriesId },
                dataType: "json",
                traditional: true,
                cache: false,
                async: true,
                success: function (data) {
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                               .css('top', e.pageY + moveDown)
                               .css('left', e.pageX + moveLeft)
                               .append('<table>' + data + '</table>')
                               .appendTo('body');
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
});
function showCustomerReservationDialog(customerId) {
    var button = {
        success: {
            label: "Assign to Ticket",
            className: "btn btn-primary",
            callback: function () {
                if ($("input[name=seriesIds]:checked").length > 0) {
                    $("#AssignReservationsToTicket").submit();
                }
                else{
                    return false;
                }
            }
        },
        danger: {
            label: "Cancel",
            className: "btn btn-default",
            callback: function () {
                return true;
            }
        }
    };

    var box = bootbox.dialog({
        size: 'large',
        title: "Customer Reservation",
        message: '<hr/><form id="AssignReservationsToTicket" method = "POST" action = "checkCustomerReservation" >'
                +'<div id="customer-reservation-container"><table id="series-reserved-container" class="table table-bordered table-hover dataTable text-center"><tbody id="tickets-container"></tbody></table></div><input type="hidden" name="requestId" value="'
                    + $("#requestId").val() + '" /><input type ="hidden" name="ticketId" value = "' + $("#ticketId").val() + '" />'
                    + '<input type ="hidden" name="serviceOfferingName" value = "' + $("#serviceOfferingName").val() + '" />'
                    + '<input type ="hidden" name="ticketMetaDataId" value = "' + $("#ticketMetaDataId").val() + '" />'
                    + '</form> <div id="load-more"> loadMore</div>',
        buttons: button
    });
    var onLoadUrl = '/AxiosSeries/checkCustomerReservationF?customerId=' + customerId + "&start=0";
    $.ajax({
        url: onLoadUrl,
        type: "POST",
        dataType: "json",
        traditional: true,
        cache: false,
        async: true,
        success: function (data) {
            if (data.status) {
                $(data.content).hide().appendTo($("#series-reserved-container")).fadeIn(1000);
                $("#load-more").text(data.message);
                $(document).trigger("contentChanged");
            } else {
                $("#load-more").text(data.message);
            }
        }
    });
    var url = '/AxiosSeries/checkCustomerReservationF?customerId=' + customerId;
    box.on("shown.bs.modal", function () {
        $().loadMore({
            button: $("#load-more"),
            container: $("#series-reserved-container"),
            auto: false,
            url: url,
        });
    });

}
function showDirectorTypeDialog(url) {
    var button = {
        success: {
            label: "Ok",
            className: "btn btn-primary",
            callback: function () {
                location.href = url+ "&type=" + $("input[name=directorType]:checked").val();
            }
        },
        danger: {
            label: "Cancel",
            className: "btn btn-default",
            callback: function () {
                return true;
            }
        }
    };
    var box = bootbox.dialog({
        size: 'small',
        title: "Choose Director Type",
        message: '<form id="directorTypeForm" method = "POST" action = "closeAndForward" >'
                + '<input type="radio" name="directorType" value="Director Approval"  /> Director Approval <br/>'
                + '<input type="radio" name="directorType" value="Director and CEO Approval" /> Director and CEO Approval'
             + '</form>',
        buttons: button
    });
}
function showCloseAndApproveDialog(url) {
    var button = {
        success: {
            label: "Close And Approve",
            className: "btn btn-primary",
            callback: function () {
                var remark = $("#remarkTextArea").val();
                if (remark.trim() == "") {
                    return false
                } else {
                    location.href = url + "&remark=" + remark;
                }
            }
        },
        danger: {
            label: "Cancel",
            className: "btn btn-default",
            callback: function () {
                return true;
            }
        }
    };
    var box = bootbox.dialog({
        size: 'small',
        title: "Please Enter Remark",
        message: 'Remark :<br/> <textarea id="remarkTextArea" name = "remarkTextArea">' + $("#requestedNumebrs").val() + '</textarea><br/>',
        buttons: button
    });
}
function showRemarkDialog(url) {
    var button = {
        success: {
            label: "Close And Reject",
            className: "btn btn-primary",
            callback: function () {
                var remark = $("#remarkTextArea").val();
                if (remark.trim() == "") {
                    return false
                } else {
                    location.href = url + "&remarkTextArea=" + $("#remarkTextArea").val();
                }
            }
        },
        danger: {
            label: "Cancel",
            className: "btn btn-default",
            callback: function () {
                return true;
            }
        }
    };
    var box = bootbox.dialog({
        size: 'small',
        title: "Please Enter Remark",
        message: 'Remark :<br/> <textarea id="remarkTextArea" name = "remarkTextArea">' + $("#requestedNumebrs").val() + '</textarea><br/>',
        buttons: button
    });
}
function showMessage(message) {
    var button = {
        success: {
            label: "OK",
            className: "btn btn-primary",
            callback: function () {
                return true;
            }
        }
    };

    var box = bootbox.dialog({
        size: 'medium',
        title: "Info",
        message: message,
        buttons: button
    });
}
