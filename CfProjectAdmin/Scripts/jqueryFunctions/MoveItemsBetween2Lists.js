$(function () {
    function moveItems(origin, dest) {
        $(origin).find(':selected').remove();
        
    }
    
    
    function cloneItems(origin, dest) {
        var destItems = new Array();
        var selected = new Array();
        $(origin).find(':selected').each(function (){
            selected.push($(this).html());
        });
        
        $(dest).find('option').each(function (){
            destItems.push($(this).html());            
        });
        valueAlreadySelected = false;
        for (var j = 0; j < selected.length; j++) {
            if (destItems.indexOf(selected[j]) >= 0) {
                //valueAlreadySelected = true
                $.msgBox({
                    title: 'WARNING',
                    content: "already existed",
                    opacity: 0.5,
                    buttons: [{ value: "OK" }],
                });
            } else {
                $(dest).append('<option vlaue="'+selected[j]+'" >'+selected[j]+'</option>');
            }                    
        }
        //if (valueAlreadySelected) {
        //    $.msgBox({
        //        title: 'WARNING',
        //        content: "allready existed",
        //        opacity: 0.5,
        //        buttons: [{ value: "OK" }],
        //    });
       // }

    }
    function moveAllItems(origin, dest) {
        $(origin).children().appendTo(dest);
    }        

    $('#left').click(function () {
        moveItems('#sbTwo', '#sbOne');
        $("#sbTwo option").prop("selected", true);
        
        
    });
    $('#left1').click(function () {
        moveItems('#sbFour', '#sbThree');
        $("#sbFour option").prop("selected", true);

        
    });

    $('#right').on('click', function () {
       
        cloneItems('#sbOne', '#sbTwo');
        $("#sbTwo option").prop("selected", true);
        
    });
    $('#right1').on('click', function () {        
        cloneItems('#sbThree', '#sbFour');
        $("#sbFour option").prop("selected", true);
        
        
    });

    //$("#myForm").submit(function (e) {
    //        //$("#sbTwo option").attr("selected", "selected");
    //        $("#sbTwo").each(function () {
    //            $("#sbTwo option").prop("selected", true);
    //        });
    //        $("#sbFour").each(function () {
    //            $("#sbFour option").prop("selected", true);
    //        });
    //    });
    //$("#myForm").submit(function (e) {
    //        //$("#sbFour option").attr("selected", "selected");
    //        $("#sbFour").each(function () {
    //            $("#sbFour option").attr("selected", "selected");
    //        });
    //    });
    

    //$('#leftall').on('click', function () {
    //    moveAllItems('#sbTwo', '#sbOne');
    //    $('#sbOne').find(':selected').removeAttr('selected');        
    //});

    //$('#rightall').on('click', function () {
    //    moveAllItems('#sbOne', '#sbTwo');
    //});
    //$('#leftall1').on('click', function () {
    //    moveAllItems('#sbFour', '#sbThree');
    //    $('#sbThree').find(':selected').removeAttr('selected');
    //});

    //$('#rightall1').on('click', function () {
    //    moveAllItems('#sbThree', '#sbFour');
    //});    
});