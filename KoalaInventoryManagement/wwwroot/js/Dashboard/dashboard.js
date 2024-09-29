//use an api in the controller then call it by ajax and in case of success
//put the response in the data of the charts and initialize them

//pie dart ((Product By Category))

//pie chart
var ctx = document.getElementById("pieChart");
var myChart = new Chart(ctx, {
    type: 'pie',
    data: {
        datasets: [{
            data: [150, 50, 100, 120,40],
            backgroundColor: [
                "#8241f7",
                "#6e84fe",
                "#b189d8",
                "#6e84fe",
                "#7a5af9"
            ]
        }],
        labels: [
            "Electronics",
            "Clothing",
            "Groceries",
            "Furniture",
            "Accessories"
        ]
    }
});

//donut chart (Product By Supplier)
Morris.Donut({
    element: 'Product-By-Supplier',
    data: [
        { label: "PF Concept B.V.", value: 123 },
        { label: "Anda Present Kft.", value: 23 },
        { label: "Gorfactory S.A.", value: 56 },
        { label: "Paul Stricker, S.A.", value: 23 },
        { label: "Inspirion GmbH", value: 80 },
    ],
    colors: ['#8241f7', '#6e84fe','#b189d8']
});

//Bar chart(average product stock by category)
Morris.Bar({
    element: 'average-stock',
    data: [
        { category: 'Electronics', min_stock: 50, current_stock: 150, max_stock: 200 },
        { category: 'Clothing', min_stock: 30, current_stock: 100, max_stock: 120 },
        { category: 'Groceries', min_stock: 100, current_stock: 200, max_stock: 250 },
        { category: 'Furniture', min_stock: 20, current_stock: 60, max_stock: 80 },
        { category: 'Accessories', min_stock: 20, current_stock: 50, max_stock: 70 }
    ],
    xkey: 'category',  // Categories displayed on the x-axis
    ykeys: ['min_stock', 'current_stock', 'max_stock'],  // Values for each category
    labels: ['Minimum Stock', 'Current Stock', 'Maximum Stock'],  // Labels for each bar section
    barColors: ['#b189d8', '#6e84fe', '#8241f7'],  // Colors for the bars
    hideHover: 'auto',  // Hide hover effect automatically
    gridLineColor: 'transparent'  // Make grid lines transparent
});


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