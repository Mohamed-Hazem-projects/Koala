// $('#download-pdf').on('click', function (data) {
//   const url = '/Report/GenerateReportPdf';
//   $.ajax({
//     url: url,
//     method: 'POST',
//     data: data,
//     success: function (response) {},
//     error: function () {},
//   });
// });

function downloadPdf() {
  const url = '/Report/GenerateReportPdf';
  const parsedData = JSON.parse($(this).attr('data-report'));
  debugger;
  $.ajax({
    url: url,
    method: 'POST',
    data: JSON.stringify(parsedData),
    success: function (response) {},
    error: function () {},
  });
}
