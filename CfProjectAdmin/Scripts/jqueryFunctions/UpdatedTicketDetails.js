$(document).ready(function () {
    var moveLeft = 20;
    var moveDown = 10;
    $(document).on('click', '#closeAndApprove', function () {
        var url = $(this).attr('action-url');
        showCloseAndApproveDialog(url);
    });
    $(document).on('click', '#closeAndReject', function () {
        showRemarkDialog($(this).attr('action-url'));
    });
    $(document).on('click', '#showRequestInformation', function () {
        showRequestInformationForm();
    });
    if ($("#unreservedCount").val() != "") {
        var box = bootbox.dialog({
            size: 'small',
            title: "Unreserved Count",
            message: $("#unreservedCount").val() + ': Numbers not reserved check if they are reserved by other users'
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
        var numberId = $(this).attr("number_Id");
        $.ajax({
            url: "/Pools/getrelatedNormalPools",
            type: "GET",
            data: { clickedNumber: numberId },
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
                console.log(data);
            }
        });
    });
    $(document).click(null, function () {
        $('div#relatedPools_popUp').html('');
        $('div#relatedPools_popUp').hide();
    });
    
});
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
function showRequestInformationForm() {
    var button = {
        success: {
            label: "OK",
            className: "btn btn-primary",
            callback: function () {
                $("#form-container").find('.error').remove();
                var requesterGroup = $("#requesterGroup").val(); var requester = $("#requester").val();
                var idType = $("#idType").val(); var customerName = $("#customerName").val();
                var customerId = $("#customerId").val(); var contractNumber = $("#contractNumber").val();
                var requestReason = $("#requestReason").val(); var oldNumber = $("#oldNumber").val();
                var alternativeNumber = $("#alternativeNumber").val();
                if (oldNumber == '' || oldNumber == null || (Math.floor(oldNumber) == oldNumber && $.isNumeric(oldNumber) && oldNumber.length == 8)) {
                    url = '/AxiosReservation/viewUpdatedTicketDetails?idType=' + idType + "&contractNumber=" + contractNumber
                     + "&customerId=" + customerId + "&customerName=" + customerName + "&requestReason=" + requestReason + "&oldNumber=" + oldNumber + "&alternativeNumber=" + alternativeNumber + "&saveReqInfo=true"
                        + "&requestId=" + $("#requestId").val();
                    location.href = url;
                } else {
                    $("#oldNum").append("<span class='error'>Invalid Number</span>");
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
        size: 'medium',
        title: "Request Information",
        message: '<span id="form-container">'
                    + '<span class="col-xs-3 j-form-lable">Id Type :</span> <span class="col-xs-9 j-select-picker"><select name="idType" id="idType" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = " true" ></select></span><br />'
                    + '<span class="col-xs-3 j-form-lable">Customer Name :</span> <span class="col-xs-9"><input readonly = "true" class="form-control" type="text" name="customerName" id="customerName" /></span><br/>'
                    + '<span class="col-xs-3 j-form-lable">Customer ID :</span> <span class="col-xs-9"><input readonly = "true" class="form-control" type="text" name="customerId" id="customerId" /></span><br/>'
                    + '<span class="col-xs-3 j-form-lable">Contract Number :</span> <span class="col-xs-9"><input readonly = "true" class="form-control" type="text" name="contractNumber" id="contractNumber" /></span><br/>'
                    + '<span class="col-xs-3 j-form-lable">Request Reason :</span> <span class="col-xs-9 j-select-picker"><select name="requestReason" id="requestReason" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = " true" ></select></span><br/>'
                    + '<span id="oldNumContaier"><span class="col-xs-3 j-form-lable">Old Number :</span> <span class="col-xs-9" id="oldNum"><input class="form-control" type="text" name="oldNumber" id="oldNumber" /></div></span></span><br/>'
                    + '<span class="col-xs-3 j-form-lable">Alternative Number :</span> <span class="col-xs-9"><input class="form-control" type="text" name="alternativeNumber" id="alternativeNumber" /></span><br/>'
                + '</span>'
                ,
        buttons: button
    });
    box.on("shown.bs.modal", function () {
        $('#oldNumContaier').hide();
        $(document).on('change', '#requestReason', function () {
            if ($(this).val() == 'CHANGE') {
                $('#oldNumContaier').fadeIn();
            } else {
                $('#oldNumContaier').fadeOut();
            }
        });
        var requestInfo = JSON.parse($("#requestInfo").val());
        var idType = JSON.parse($("#idTypes").val());
        $("#requesterGroup").val(requestInfo.requesterGroup);
        $("#requester").val(requestInfo.requester);
        $("#contractNumber").val(requestInfo.contractNumber);
        $("#customerId").val(requestInfo.customerId);
        $("#customerName").val(requestInfo.customerName);
        $("#requestReason").val(requestInfo.requestReason);
        $("#oldNumber").val(requestInfo.oldNumber);
        $("#alternativeNumber").val(requestInfo.alternativeNumber);

        var newLineSelected = '';
        var changeSelected = '';

        if (requestInfo.requestReason == "NEW LINE") {
            newLineSelected = 'selected = "true"';
        }
        if (requestInfo.requestReason == "CHANGE") {
            changeSelected = 'selected = "true"';
        }
        $("#requestReason").append('<option value="' + "NEW  LINE" + '"' + newLineSelected + '>' + "NEW LINE" + '</option>');
        $("#requestReason").append('<option value="' + "CHANGE" + '"' + changeSelected + '>' + "CHANGE" + '</option>');

        $.each(idType, function (key, value) {
            $("#idType").append('<option value="' + value + '">' + value + '</option>');
        });
        $(".selectpicker").selectpicker();
    });
}