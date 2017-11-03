$(document).ready(function () {
    
    $(document).on('change', '#selGroup', function (e) {
        var urlmodel = "/Group/GetRequestersInGroup/";
        $.ajax({
            url: urlmodel,//"@Url.Action('GetRequestersInGroup','Group')",
            data: { groupID: $('#selGroup').val() },
            type: "GET",
            dataType: "json",
            success: function (data) {
                if (data != null) {
                    loadData(data);
                    $("#UpdatePanel3").html('');
                }
                else {
                    $("#UpdatePanel1").html('<b>There is no requesters in this group<b>');
                    $("#UpdatePanel2").html('');
                    $("#UpdatePanel3").html('');
                }
            },
            error: function (error) {
                //alert("Failed! Please try again.");
            }
        });

    });

    function loadData(data) {
        // Here we will format and load data               
        var tab = $('<table class="table table-bordered table-hover dataTable" style="text-align:center"></table>');
        var thead = $('<tbody></tbody>');
        var tb = $('<tr>  </tr>');
        tb.append('<th >  </th>');
        tb.append('<th>Row ID</th>');
        tb.append('<th>Requester Name</th>');
        tb.append('<th>Syriatel ID</th>');
        thead.append(tb);
        //thead.append('<th >  </th>');
        //thead.append('<th>Row ID</th>');
        //thead.append('<th>Requester Name</th>');
        //thead.append('<th>Syriatel ID</th>');
        tab.append(thead);
        var x = 0;

        $.each(data, function (i, val) {
            x++;
            var trow = $('<tr></tr>');

            trow.append(' <td><input type="checkbox" class="cb" name="requestersID" id="checkID' + x + '" value="' + val.REQUESTER_ID + '"/> </td>');
            trow.append('<td>' + x + '</td>');
            trow.append('<td>' + val.REQUESTER_NAME + '</td>');
            trow.append('<td>' + val.SYRIATEL_ID + '</td>');
            tab.append(trow);
        });
        $("tr:even", tab).css('background-color', '#C4C4C4');
        $("#UpdatePanel1").html(tab);
                    
        var btn = $('<input type="button" id="btnRemove" value="Remove" class="btn btn-primary btn-flat"/>');
        $("#UpdatePanel2").html(btn);
                
    };


    $(document).on('click', '#btnRemove', function (e) {
        var urlmodel = "/Group/RemoveRequesters/";
        var selectedRequesters = new Array();
        $("input[name='requestersID']:checked").each(function () {
            selectedRequesters.push(this.value);
        });
        $.ajax({
            url: urlmodel,
            data: { groupID: $('#selGroup').val(), requestersID: selectedRequesters.toString() },
            type: "GET",
            dataType: "json",
            success: function (data) {
                if (data != null) {
                    loadData(data);
                    $("#UpdatePanel3").html('');
                }
                else {
                    $("#UpdatePanel3").html('No requesters have been selected.');
                }

            },
            error: function (error) {
                alert("Failed! Please try again.");
            }
        });

    });

});
