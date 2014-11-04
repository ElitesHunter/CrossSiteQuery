/// <reference path="jquery-1.11.1.min.js" />
/// <reference path="csq.commoms.js" />

(
    function ($) {
        $.fn.dropdown = function () {
            this.attr("readonly", "readonly");
            var bindid = this.attr("id");
            var $div = $(String.format("DIV[bindid='{BindId}']", { BindId: bindid }));
            Demo.CacheData.HiddenElement.push($div);
            this.click(function (e) {
                Demo.cancelEventBubble(e);
                $div.css("top", String.format("{Top}px", { Top: $(this).offset().top + $(this).height() + 2 }));
                $div.slideDown("fast");
            });
            var me = this;
            $div.find("ul li").click(function (e) {
                Demo.cancelEventBubble(e);
                me.val($(this).text());
                me.attr("selectedvalue", $(this).attr("v"));
                $div.slideUp("fast", function () { $div.hide(); });
            });
            return this;
        }
    }
)(jQuery);