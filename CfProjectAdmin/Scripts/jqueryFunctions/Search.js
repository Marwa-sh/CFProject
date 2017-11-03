(function($) {
    $.fn.search = function(options) {
        var settings = $.extend({
            moreLBL: 'More',
            noMoreLBL: 'No More!',
            errorLBL: 'Try Again',
            container: $('body'),
            fadeInSpeed: 1000,
            button: null,
            url: null
        }, options);
        var parent = $(this);
     //   console.log(parent);
        parent.find('[type=text]').keyup(function (e) {            
            if (e.keyCode == 13) {//press enter                
                parent.find('#btnSearch').trigger('click');
            }
        });
        parent.find('[type=button]').click(function() {
            if (!settings.url) {
                return;
            }
            settings.container.html('');
            if (settings.button) {
                settings.button.addClass('activate').text("");
            }

            $('body').addClass('wait');
            var ajaxURL = settings.url;



            //check for filters
            $('.filter_value').each(function () {
                ajaxURL += $(this).val() +"&";
            });           

            //check for sort 
            $('.Sort').each(function () {
                ajaxURL += 'sort=' + $(this).val() + "&";
                
            });
            console.log(ajaxURL);
            

         //   console.log(ajaxURL);

            var search_value = parent.find('[type=text]').val();
            var url_var = '';
            
            url_var = ajaxURL + "&search=" + encodeURI(search_value) + "&start=0",
        //   console.log(url_var);


            $.ajax({
                type: "GET",
                url: url_var, //+ "&search=" + encodeURI(search_value) + "&start=0",
                dataType: 'json',
                cache: false,
                async: true,                
                success: function(data) {                    
//                    console.log(settings.url);
                    if (settings.button) {
                        settings.button.text(settings.moreLBL);
                    }
                    if (data.status) {
                        $(data.content).hide().appendTo(settings.container).fadeIn(settings.fadeInSpeed);
                        $(document).trigger("contentChanged");
                        $(document).trigger("searchChanged");

                    } else {
                        if (settings.button) {
                           settings.button.text(data.message);
                       }
                    }
                },
                error: function(data) {
              //      console.log(data);
                },
                complete: function () {                    
                    if (settings.button) {
                        settings.button.removeClass('activate');                      
                    }
                    $('#search_value').remove();
                    $('body').append('<input type="hidden" value="search=' + encodeURI(search_value) + '" id="search_value"/>');
                    $('body').removeClass('wait');
                }
            });
        });
    };
}(jQuery));