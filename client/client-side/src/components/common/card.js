import React from 'react';

class Cards extends React.Component{

    constructor(props) {
        super(props);
    
        this.state = {
          items: [],
          DataisLoaded: false,
        };
      }
    
      // ComponentDidMount is used to
      // execute the code
      componentDidMount() {
        fetch("https://jsonplaceholder.typicode.com/users")
          .then((res) => res.json())
          .then((json) => {
            this.setState({
              items: json,
              DataisLoaded: true,
            });
          });
      }
      render() {
        const { DataisLoaded, items } = this.state;
        if (!DataisLoaded)
        //   return (
        //     <div>
        //       <h1> Pleses wait some time.... </h1>{" "}
        //     </div>
        //   );
    return (
        <><h1>this is a test</h1>
        <div class="container d-flex justify-content-center mt-50 mb-50 p-5">
        <div class="row">
        {" "}
            {items.map((item) => (
            <div class="col-md-4 mt-2">
                <div id="C100/100" class="card">
                    <i id="icon_unavailable" class="bi bi-x-square-fill display-4"></i>
                    <div class="card-body text-center">
                        <h3 class="mb-0 font-weight-semibold text-white"><strong>{item.id}</strong></h3>
                        <h6 class="font-weight-semibold mb-2 text-white">{item.username}</h6>
                        <div class="mb-2">
                            <h6 class="font-weight-semibold mb-2 text-white">{item.name}</h6>
                            <h6 class="font-weight-semibold mb-2 text-white">{item.email}</h6>
                        </div>
                    </div>
                </div>
            </div>
            ))}
          </div>
        </div></>  
    );
    }
}

export default Cards;