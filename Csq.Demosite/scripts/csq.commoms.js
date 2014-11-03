/// <reference path="jquery-1.11.1.min.js" />

Exceptions = {
    argsNumber: "Wrong number of method parameters!",
    invalidType: "Invalid method parameter's type!"
};

String.format = function (format, obj) {
    /// <summary>
    /// 格式化字符串。
    /// </summary>
    /// <param name="format" type="String">格式化字符串。</param>
    /// <param name="obj" type="Object">JSon Object。</param>
    /// <returns type="String">格式化后的字符串。</returns>

    if (arguments.length < 1)
        throw Exceptions.argsNumber;
    if (typeof format != "string")
        throw Exceptions.invalidType;

    var result = '';
    if (obj === null && obj === undefined) result = format;
    else {
        result = format;
        var reg;
        for (var key in obj) {
            reg = '\\{(' + key + ')\\}'
            reg = new RegExp(reg, 'gi');
            result = result.replace(reg, obj[key]);
        }
    }
    return result;
}

Demo = {
    Events: {
        windowResizeHandler: function ($win) {
            /// <summary>
            /// Window对象Resize事件处理函数。
            /// </summary>
            /// <param name="$win" type="JQuery">Window对象的JQuery形式。</param>
            resizeBodyEle = function () {
                /// <summary>
                /// 重置Body元素。
                /// </summary>

                $("body").css("height", String.format("{Height}px", { Height: $win.height() }));
            }
            resizeBodyEle();

            resizeCtrlsPanelEle = function () {
                /// <summary>
                /// 重置ID为CtrlsPanel的元素。
                /// </summary>

                $("#CtrlsPanel").css("height", String.format("{Height}px", { Height: $win.height() }));
            }
            resizeCtrlsPanelEle();

            resizeSplitPanelEles = function () {
                /// <summary>
                /// 重置左右分区布局。
                /// </summary>

                $("#LeftCtrlsPanel").css("height", String.format("{Height}px", { Height: $win.height() }));
                $("#RightCtrlsPanel").css("height", String.format("{Height}px", { Height: $win.height() })).css("width", String.format("{Width}px", { Width: $win.width() - 200 }));
            }
            resizeSplitPanelEles();
        }
    },
    RegularExpressions: {
        ValidInnerIds: /^\d*(,\d*){0,2}$/
    }
}

$(window).resize(function () {
    var flag = 1;
    if (flag < 2) {
        flag++;
        Demo.Events.windowResizeHandler($(this));
    }
});