$(document).ready(function () {
    var RequestStatus = $("#requestStatus").val();
    $("#check-reservations").hide();
    if (RequestStatus !== "ASSIGNED") {
        $('input[type="submit"]').prop('disabled', true);
        $("#check-reservations").show();
    }
    $(document).on('click', '#customer-data-dialog', function () {
        if ($("#requestStatus").val() != "ASSIGNED") {
            $.msgBox({
                title: 'WARNING',
                content: "Ticket already validated",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        } else {
            showCustomerDataDialog();
        }
    });
    $(document).on('click', '#takeOverDetails', function () {
        if ($("#requestStatus").val() == "ASSIGNED") {
            $.msgBox({
                title: 'WARNING',
                content: "You must validate ticket before",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }else{
            location.href = '/AxiosReservation/showTakeOverDetails?contractNumber='+$("#contractNumber").val() + "&ticketId=" + $("#ticketId").val() +"&ticketMetaDataId=" + $("#ticketMetaDataId").val() + "&serviceOfferingName=" + $("#serviceOfferingName").val();
        }
    });
    $(document).on('click', '#checkCustomerReservation', function () {
        showCustomerReservationDialog();
    });
    $(document).on('click', '#closeAndReject', function () {
        showRemarkDialog();
    });
    
});
function showCustomerDataDialog() {
    var button = {
        success: {
            label: "Show Data",
            className: "btn btn-primary",
            callback: function () {
                var conNum = $("#contractNumberTextbox").val();
                var custId = $("#customerIdTextbox").val();
                var IDType = $("#IDType").val();
                if (conNum == "" && custId == "") {
                    return false
                } else {
                    url = '/AxiosReservation/tabsDetails?contractNumber=' + conNum + "&customerId=" + custId + "&serviceOfferingName=" + $("#serviceOfferingName").val() + "&ticketMetaDataId=" + $("#ticketMetaDataId").val() + "&ticketId=" + $("#ticketId").val() + '&IDType=' + IDType;
                    location.href = url;
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
        title: "Customer Data",
        message: 'Contract Number :<br/> <input type="text" name="contractNumberTextbox" id="contractNumberTextbox" placeholder="Enter Cont#" /><br/>'
                + 'Customer ID: <br/> <input type="text" name="customerIdTextbox" id="customerIdTextbox" placeholder="Enter Cust#" /><br/>'
                + 'IdentityType : <select name="IDType" id="IDType" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = "true"></select> <br/>',
        buttons: button
    });
    box.on("shown.bs.modal", function () {
        identityTypes = JSON.parse($("#identityTypes").val());
        $("#IDType").append('<option value="' + "" + '">' + "" + '</option>');
        $.each(identityTypes, function (key, value) {
            $("#IDType").append('<option value="' + value + '">' + value + '</option>');
        });
        $(".selectpicker").selectpicker();
    });
    
}
function showCustomerReservationDialog() {
    var button = {
        success: {
            label: "Show Data",
            className: "btn btn-primary",
            callback: function () {
                var custName = $("#customerNameTextbox").val();
                var custId = $("#customerIdTextbox").val();
                if (custName == "" && custId == "") {
                    return false
                } else {
                    url = '/AxiosReservation/checkCustomerReservation?customerName=' + custName + "&customerId=" + custId;
                    $('body').removeClass('wait');
                    $.ajax({
                        type: "POST",
                        url: url,
                        dataType: 'json',
                        cache: false,
                        async: true,
                        success: function (data) {
                            alert("conn success" + data.message);
                        },
                        error: function (data) {
                            console.log(data);
                        },
                        complete: function () {
                            $('body').removeClass('wait');

                        }
                    });
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
        title: "Check customer Reservation",
        message: 'Customer Name :<br/> <input type="text" name="customerNameTextbox" id="customerNameTextbox" placeholder="Enter Cust.Name" /><br/>'
                + 'Customer ID: <br/> <input type="text" name="customerIdTextbox" id="customerIdTextbox" placeholder="Enter Cust#" />',
        buttons: button
    });
}
function showRemarkDialog() {
    var button = {
        success: {
            label: "Close And Reject",
            className: "btn btn-primary",
            callback: function () {
                var remark = $("#remarkTextArea").val();
                if (remark.trim() == "") {
                    return false
                } else {
                    $('#validateAndCloseForm').append('<input type = "hidden" name="remarkTextArea" value = "' + remark + '" />');
                    $("#validateAndCloseForm").append("<input type='hidden' name='closeAndReject' value='closeAndReject' />");
                    $("#validateAndCloseForm").submit();
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
