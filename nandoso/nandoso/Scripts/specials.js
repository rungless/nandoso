
// This event triggers on page load
document.addEventListener("DOMContentLoaded", function () {
    loadSpecials();
});

function loadSpecials() {

    specialsModule.getSpecials(setupSpecialsTable);

}

// This is the callback for when the data comes back in the studentmodule
function setupSpecialsTable(specialsList) {
    // We need a reference to the div/table that we are going to chuck our data into
    var specialsTable = document.getElementById("specialsList");

    for (i = 0; i < specialsList.length; i++) {
        //Create row
        var row = document.createElement('tr');

        //Add the columns in the row (td /data cells)
        var productNameCol = document.createElement('td');
        productNameCol.innerHTML = specialsList[i].productName;
        row.appendChild(productNameCol);

        var priceCol = document.createElement('td');
        priceCol.innerHTML = specialsList[i].price;
        row.appendChild(priceCol);

        var descriptionCol = document.createElement('td');
        descriptionCol.innerHTML = specialsList[i].description;
        console.log(specialsList[i].description);
        row.appendChild(descriptionCol);

        //Append the row to the end of the table
        specialsTable.appendChild(row);

    }

}

