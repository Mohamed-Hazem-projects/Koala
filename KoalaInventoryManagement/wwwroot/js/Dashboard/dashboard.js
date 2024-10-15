//warehouse info section
$.get("/Dashboard/GetWarehouseDetails", function (warehouseData) {

    //donut chart (Product By Supplier)
    Morris.Donut({
        element: 'warehousesStock',
        data: warehouseData.donutData,
        colors: ['#8241f7', '#6e84fe', '#b189d8']
    });
    //pie chart
    var pieChart1 = document.getElementById("warehousesProducts");
    var myChart = new Chart(pieChart1, {
        type: 'pie',
        data: {
            datasets: [{
                data: warehouseData.productsPerWarehouse,
                backgroundColor: [
                    "#8241f7",
                    "#6e84fe",
                    "#b189d8",
                    "#6e84fe",
                    "#7a5af9"
                ]
            }],
            labels: warehouseData.warehousesNames
        }
    });

});

//change that number to get it from authorization somehow
changeCharts(1)

function warehouseChanged(id, element) {
    // Remove 'active' class from all buttons
    $(".wh-btn").removeClass("active");

    // Add 'active' class to the clicked button
    $(element).addClass("active");
    changeCharts(id)
}
var productsPieChart;
var morrisDonutChart;
var morrisBarChart;
function changeCharts(warehouseID) {
    url = `/Dashboard/GetProductsInfoPerWarehouse/${warehouseID}`
    $.get(url, function (warehouseData) {
        //pie chart
        if (productsPieChart) {
            productsPieChart.destroy();
        }
        var ctx = document.getElementById("pieChart");
        productsPieChart = new Chart(ctx, {
            type: 'pie',
            data: {
                datasets: [{
                    data: warehouseData.productNumberArray,
                    backgroundColor: [
                        "#8241f7",
                        "#6e84fe",
                        "#b189d8",
                        "#6e84fe",
                        "#7a5af9"
                    ]
                }],
                labels: warehouseData.categoriesNamesArray
            }
        });
        //donut chart (Product By Supplier)
        // Update Morris donut chart
        if (morrisDonutChart) {
            morrisDonutChart.setData(warehouseData.productsPerSupplier);  // Update the existing chart with new data
        } else {
            morrisDonutChart = Morris.Donut({
                element: 'Product-By-Supplier',
                data: warehouseData.productsPerSupplier,
                colors: ['#8241f7', '#6e84fe', '#b189d8']
            });
        }
        //Bar chart(average product stock by category)
        if (morrisBarChart) {
            morrisBarChart.setData(warehouseData.categoryStockAverages);  // Update the existing chart with new data
        } else {
            morrisBarChart = Morris.Bar({
                element: 'average-stock',
                data: warehouseData.categoryStockAverages,
                xkey: 'category',  // Categories displayed on the x-axis
                ykeys: ['min_Stock', 'current_Stock', 'max_Stock'],  // Values for each category
                labels: ['Average Minimum Stock', 'Average Current Stock', 'Average Maximum Stock'],  // Labels for each bar section
                barColors: ['#b189d8', '#6e84fe', '#8241f7'],  // Colors for the bars
                hideHover: 'auto',  // Hide hover effect automatically
                gridLineColor: 'transparent'  // Make grid lines transparent
            });
        }
        $("#whName").text(warehouseData.lowStockNotifications.warehouseName);
        let Lowstockproductscount = warehouseData.lowStockNotifications.lowStockProductsCount
        if (Lowstockproductscount == 0) {
            $("#lowStockCount").text(Lowstockproductscount);
            $("#lowStockCount").removeClass("red")
            $("#lowStockCount").addClass("green")

        } else {
            $("#lowStockCount").text(Lowstockproductscount);
            $("#lowStockCount").removeClass("green")
            $("#lowStockCount").addClass("red")
        }
        $("#lowStockProductsTable").html("");
        for(let product of warehouseData.lowStockNotifications.lowStockProducts)
        {
            $("#lowStockProductsTable").append(`<tr>
                                                    <th scope="row">${product.id}</th>
                                                    <td>${product.name}</td>
                                                    <td>${product.price}</td>
                                                    <td>${product.min_Stock}</td>
                                                    <td>${product.current_Stock}</td>
                                                    <td>${product.max_Stock}</td>
                                                </tr>`);
        }

    })
}








//sayebha 3shan shaklaha 7elw momken yt3mlha implementation lma el sales t5ls
//Area chart (profits by category)
Morris.Area({
    element: 'profits-by-category',
    data: [
        { month: '2024-01', electronics: 5000, clothing: 3000, groceries: 4000, furniture: 2500, accessories: 1500 },
        { month: '2024-02', electronics: 3500, clothing: 4200, groceries: 4200, furniture: 2600, accessories: 1600 },
        { month: '2024-03', electronics: 2000, clothing: 3300, groceries: 6400, furniture: 4700, accessories: 1700 },
        { month: '2024-04', electronics: 6500, clothing: 3500, groceries: 4600, furniture: 2800, accessories: 1800 },
        { month: '2024-05', electronics: 2000, clothing: 7600, groceries: 8800, furniture: 6900, accessories: 1900 },
        { month: '2024-06', electronics: 1500, clothing: 3700, groceries: 5000, furniture: 3000, accessories: 2000 },
        { month: '2024-07', electronics: 3000, clothing: 9900, groceries: 2200, furniture: 1100, accessories: 2100 },
        { month: '2024-08', electronics: 4500, clothing: 4000, groceries: 5400, furniture: 3200, accessories: 2200 },
        { month: '2024-09', electronics: 5000, clothing: 8200, groceries: 3600, furniture: 1300, accessories: 2300 }
    ],
    lineColors: ['#433878', '#7E60BF', '#5638df', '#E4B1F0', '#FFE1FF'],
    xkey: 'month',
    ykeys: ['electronics', 'clothing', 'groceries', 'furniture', 'accessories'],
    labels: ['Electronics$', 'Clothing$', 'Groceries$', 'Furniture$', 'Accessories$'],
    pointSize: 0,
    lineWidth: 0,
    fillOpacity: 0.8,
    behaveLikeLine: true,
    gridLineColor: 'transparent',
    hideHover: 'auto'
});