$(function(){
    function postNewMovie( e ){
        var dict = {
        	Title : this["title"].value,
          Genre : this["genre"].value,
        	Director: this["director"].value
        };

        $.ajax({
            url: 'https://localhost:44352/api/movie',
            dataType: 'json',
            type: 'post',
            contentType: 'application/json',
            data: JSON.stringify(dict),
            success: function( data, textStatus, jQxhr ){
                $('#response pre').html( data );
            },
            error: function( jqXhr, textStatus, errorThrown ){
                console.log( errorThrown );
            }
        });

        e.preventDefault();
    }

    $('#my-form').submit( processForm );



    function getAllMovies()
    {
        $.ajax({
            url: 'http://localhost.44352/api/movie',
            type: 'get',
            dataType: 'json',
            success: function (data) {
                WriteTable(data)
            }
        });
    }
    ​   $('#allMoviesTable').submit(processForm);
    ​
    function WriteTable(data) {
        result = "<table><th>Title</th><th>Genre</th><th>Director</th>";
        $.each(data, function (index, value) {
            result += "<tr><td>" + value.Title + "</td><td>" + value.Genre + "</td><td>" + value.Director + "</td>"
        });
        result += "</table>"
        $("#allMoviesTable").html(result);
    }

  


    // $(function getAllMovies(){

    //   $.ajax({
    //     type: 'get',
    //     url: 'https://localhost:44352/api/movie',
    //     dataType: 'json',
    //     success: function(data){
    //         // $('.tableBody').empty();
    //       // $('#allMoviesTable').append("<tr><th>" + Title+ "</th><th>" + Genre+ "</th><th>"+ Director+ "</th></tr>");
    //       $.each(data, function(index, value){
    //         $('.tableBody').append(
    //           '<tr><td>' + value.Title +'</td>,<td>' + value.Genre +'</td>,<td>' +  value.Director + '</td></tr>'
    //         )
    //       });
    //     }
    //   });
    // }
    //     $('#allMoviesTable').submit(processForm);

})(jQuery);

// $.post("From Body", movie, Post(Movie movie))
