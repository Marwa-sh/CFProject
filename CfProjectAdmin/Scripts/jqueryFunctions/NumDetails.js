$(document).ready(function () {
    var numId = $("input[name=numId]").val();
    $("#changeClass").click(function (e) {
        e.preventDefault();
        $.ajax({
            url: "/Numbers/getAllClassification",
            type: "POST",
            data: {},
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                $.msgBox({
                    title: 'Change number classification',
                    content: data,
                    type: "confirm",
                    opacity: 0.5,
                    buttons: [{ value: "Save" }, { value: "Cancel" }],
                    success: function (result) {                        
                        if (result == "Save") {
                            var newClass = $('.selected').find("option:selected").attr('classId');
                            //var newClass = $('.selected').val(selectedVal);
                            $.msgBox({
                                title: 'Enter Your Password',
                                type: "prompt",
                                inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
                                opacity: 0.5,
                                buttons: [{ value: "Yes" }, { value: "No" }],
                                success: function (result) {
                                    var pass = $("input[name=password]").val();
                                    if (result == "No")
                                        return true;
                                    else {
                                        $.ajax({
                                            url: "/MemberManagement/validateSuperActionPassword",
                                            type: "POST",
                                            data: { userPassword: pass },
                                            dataType: "json",
                                            traditional: true,
                                            cache: false,
                                            async: true,
                                            success: function (data) {
                                                if (data == false)
                                                    $.msgBox({
                                                        title: 'WARNING',
                                                        content: "Error Password",
                                                        opacity: 0.5,
                                                        buttons: [{ value: "OK" }],
                                                        success: function (result) {
                                                            if (result == "OK")
                                                                return true;
                                                        }
                                                    })
                                                else {
                                                    $('body').addClass('wait');
                                                    $.ajax({
                                                        url: "/Numbers/changeNumClassification",
                                                        type: "POST",
                                                        data: { numberId: numId, newClassId: newClass },
                                                        dataType: "json",
                                                        traditional: true,
                                                        cache: false,
                                                        async: true,
                                                        success: function (data) {
                                                            if (data = "success") {
                                                                location.reload();
                                                            }
                                                            else {
                                                                $.msgBox({
                                                                    title: 'error',
                                                                    content: data,
                                                                    opacity: 0.5,
                                                                    buttons: [{ value: "OK" }],
                                                                    success: function (result) {
                                                                        location.reload();
                                                                    }
                                                                });
                                                            }
                                                        },
                                                        complete: function () {
                                                            $('body').removeClass('wait');
                                                        }
                                                    });
                                                }
                                            }
                                        })
                                    }
                                }
                            })
                        }
                        else
                            return true;
                    }
                })
            }
        });

    });
    $("#changePrice").click(function (e) {
        e.preventDefault();
        $.msgBox({
            title: 'Change number price',
            type: "confirm",
            content: "<input type='text' class='newPrice' value='' />",
            opacity: 0.5,
            buttons: [{ value: "Save" }, { value: "Cancel" }],
            success: function (result) {
                if (result == "Save") {
                    var newPrice = $(".newPrice").val();
                    $.msgBox({
                        title: 'Enter Your Password',
                        type: "prompt",
                        inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
                        opacity: 0.5,
                        buttons: [{ value: "Yes" }, { value: "No" }],
                        success: function (result) {
                            var pass = $("input[name=password]").val();
                            if (result == "No")
                                return true;
                            else {
                                $.ajax({
                                    url: "/MemberManagement/validateSuperActionPassword",
                                    type: "POST",
                                    data: { userPassword: pass },
                                    dataType: "json",
                                    traditional: true,
                                    cache: false,
                                    async: true,
                                    success: function (data) {
                                        if (data == false)
                                            $.msgBox({
                                                title: 'WARNING',
                                                content: "Error Password",
                                                opacity: 0.5,
                                                buttons: [{ value: "OK" }],
                                                success: function (result) {
                                                    if (result == "OK")
                                                        return true;
                                                }
                                            })
                                        else {
                                            $('body').addClass('wait');
                                            $.ajax({
                                                url: "/Numbers/changeNumPrice",
                                                type: "POST",
                                                data: { numberId: numId, newPrice: newPrice },
                                                dataType: "json",
                                                traditional: true,
                                                cache: false,
                                                async: true,
                                                success: function (data) {
                                                    if (data = "success") {
                                                        location.reload();
                                                    }
                                                    else {
                                                        $.msgBox({
                                                            title: 'error',
                                                            content: data,
                                                            opacity: 0.5,
                                                            buttons: [{ value: "OK" }],
                                                            success: function (result) {
                                                                location.reload();
                                                            }
                                                        });
                                                    }
                                                },
                                                complete: function () {
                                                    $('body').removeClass('wait');
                                                }
                                            });
                                        }
                                    }
                                });
                            }
                        }
                    })
                }
                else
                    return true;
            }
        })
    });
})