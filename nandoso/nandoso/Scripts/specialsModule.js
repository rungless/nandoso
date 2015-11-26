


var specialsModule = (function () {
    // Return anything that you want to expose outside the closure
    return {
        getSpecials: function (callback) {
            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://nandosogy.azurewebsites.net/api/specials",
                success: function (data) {
                    callback(data);
                }
            }); 
        }
    };
}());