/// <reference path="jquery-1.11.1.min.js" />
/// <reference path="csq.commoms.js" />

(
    function ($) {
        $.fn.singleline = function () {
            /// <summary>
            /// 单行录入框插件。
            /// </summary>

            var emptyVal = this.attr("emptyvalue");
            var me = this;

            this.__initialize = function () {
                this.focus(function () {
                    if (me.val() === emptyVal) me.val("");
                });
                this.blur(function () {
                    if (me.val() === "") me.val(emptyVal);
                });
                return this;
            }

            this.isEmpty = function () {
                return this.val() === "" || this.val() == emptyVal;
            }

            this.isValid = function (regex) {
                return regex.test(this.val());
            }

            return this;
        }
    }
)(jQuery)