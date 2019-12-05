(function($){
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



    $(function getAllMovies(){
      $.ajax({
        type: 'get',
        url: 'https://localhost:44352/api/movie',
        success: function(data){
          $('#allMoviesTable').empty();
          $('#allMoviesTable').append('<tr><th>Title</<th><th>Genre</th><th>Director</th><tr>');
          $.each(Movies, function(i, item){
            $('#allMoviesTable').append(<tr>'<td>data[i].Title</td>' '<td>data[i].Genre</td>' '<td>data[i].Director</td>'</tr>)
          })
        }
      })
    }
        $('#allMoviesTable').submit( processForm );

})(jQuery);

//$.post("From Body", movie, Post(Movie movie))
