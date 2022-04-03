import React from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import Tabs from "react-bootstrap/Tabs";
import Tab from "react-bootstrap/Tab";

class App extends React.Component {
  Constructor;
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
    fetch("https://localhost:8888/api/rooms")
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
    const mappedItems = items.map((item) => item.size == "S");
    function change () {
      if(document.getElementById(test).status == 'true'){
        document.getElementById(test).status = "icon_available";
      }else{
        document.getElementById(test).status = "icon_unavailable";
      }
    }
    // function change2 (iconID){
    //   if(document.getElementById(test).status=="true"){
    //     document.getElementById(test).className = "bi bi-check-square-fill display-4";
    //   }else{
    //     document.getElementById(test).className = "bi bi-x-square-fill display-4";
    //   }
    // }
    // const { items2 } = this.props.items.filter(function (item) {
    //   return item.size == "S";
    // });

    if (!DataisLoaded)
      return (
        <div>
          <h1> Your data didn't load :/ </h1>{" "}
        </div>
      );
    return (
      <div class="App">
        {/* <div style={{ display: "block", width: 700, padding: 30 }}> */}
        {/* <h4>myBama Room Status</h4> */}
        <div id="jumbotron" class="p-5 mb-4 text-white rounded-3">
          <img src="https://culverhouse.ua.edu/wp-content/uploads/2021/09/hewson-1-scaled-e1631133826890.jpg">
          {/* <div class="container-fluid py-5">
          <h1 class="display-5 fw-bold">myBama Room Status</h1>
          <p class="col-md-8 fs-4"></p>
        </div> */}
        </img>
      </div>
        <Tabs className="nav-pills justify-content-center" defaultActiveKey="first">
          <Tab className="tab-content" eventKey="first" title="All">
            <div class="container d-flex justify-content-center mt-50 mb-50 p-5">
              <div class="row">
                {" "}
                {items.map((item) => (
                  <div class="col-md-4 mt-5">
                    <div id="test" class="card">
                      <i
                        id={change}
                        class="bi bi-clock display-4"
                      ></i>
                      <div class="card-body text-center">
                        <h3 class="mb-0 font-weight-semibold text-white">
                          <strong>{item.roomNumber}</strong>
                        </h3>
                        <h6 class="font-weight-semibold mb-2 text-white">
                          {item.name}
                        </h6>
                        <div class="mb-2">
                          <h6 class="font-weight-semibold mb-2 text-white">
                            {item.status}
                          </h6>
                          <h6 class="font-weight-semibold mb-2 text-white">
                            {item.size}
                          </h6>
                        </div>
                      </div>
                    </div>
                  </div>
                ))}
              </div>
            </div>
          </Tab>

          <Tab className="tab-content" eventKey="second" title="Small">
            <div class="container d-flex justify-content-center mt-50 mb-50 p-5">
              <div class="row">
                {" "}
                {/* {items.sort((a, b) => (a.size > b.size) ? 1 : -1)} */}
                {items
                .filter(item => item.size === 'S')
                .map(item =>
                    <div key={item.roomNumber} class="col-md-4 mt-5">
                      <div id="test" class="card">
                        <i
                          id={change}
                          class="bi bi-clock display-4"
                        ></i>
                        <div class="card-body text-center">
                          <h3 class="mb-0 font-weight-semibold text-white">
                            <strong>{item.roomNumber}</strong>
                          </h3>
                          <h6 class="font-weight-semibold mb-2 text-white">
                            {item.name}
                          </h6>
                          <div class="mb-2">
                            <h6 class="font-weight-semibold mb-2 text-white">
                              {item.status}
                            </h6>
                            <h6 class="font-weight-semibold mb-2 text-white">
                              {item.size}
                            </h6>
                          </div>
                        </div>
                      </div>
                    </div>
                  )
                }
              </div>
            </div>
          </Tab>

          <Tab className="tab-content" eventKey="third" title="Medium">
            <div class="container d-flex justify-content-center mt-50 mb-50 p-5">
              <div class="row">
                {" "}
                {items
                .filter(item => item.size === 'M')
                .map(item =>
                        <div key={item.roomNumber} class="col-md-4 mt-5">
                          <div id="test" class="card">
                            <i
                              id={change}
                              class="bi bi-clock display-4"
                            ></i>
                            <div class="card-body text-center">
                              <h3 class="mb-0 font-weight-semibold text-white">
                                <strong>{item.roomNumber}</strong>
                              </h3>
                              <h6 class="font-weight-semibold mb-2 text-white">
                                {item.name}
                              </h6>
                              <div class="mb-2">
                                <h6 class="font-weight-semibold mb-2 text-white">
                                  {item.status}
                                </h6>
                                <h6 class="font-weight-semibold mb-2 text-white">
                                  {item.size}
                                </h6>
                              </div>
                            </div>
                          </div>
                        </div>
                      )
                    }
              </div>
            </div>
          </Tab>

          <Tab className="tab-content" eventKey="fourth" title="Large">
            <div class="container d-flex justify-content-center mt-50 mb-50 p-5">
              <div class="row">
                {" "}
                {items
                .filter(item => item.size === 'L')
                .map(item =>
                        <div key={item.roomNumber} class="col-md-4 mt-5">
                          <div id="test" class="card">
                            <i
                              id={change}
                              class="bi bi-clock display-4"
                            ></i>
                            <div class="card-body text-center">
                              <h3 class="mb-0 font-weight-semibold text-white">
                                <strong>{item.roomNumber}</strong>
                              </h3>
                              <h6 class="font-weight-semibold mb-2 text-white">
                                {item.name}
                              </h6>
                              <div class="mb-2">
                                <h6 class="font-weight-semibold mb-2 text-white">
                                  {item.status}
                                </h6>
                                <h6 class="font-weight-semibold mb-2 text-white">
                                  {item.size}
                                </h6>
                              </div>
                            </div>
                          </div>
                        </div>
                      )
                    }
              </div>
            </div>
          </Tab>

          <Tab className="tab-content" eventKey="fifth" title="Available">
            <div class="container d-flex justify-content-center mt-50 mb-50 p-5">
              <div class="row">
                {" "}
                {items
                .filter(item => item.status === 'true')
                .map(item =>
                        <div key={item.roomNumber} class="col-md-4 mt-5">
                          <div id="test" class="card">
                            <i
                              id={change}
                              class="bi bi-clock display-4"
                            ></i>
                            <div class="card-body text-center">
                              <h3 class="mb-0 font-weight-semibold text-white">
                                <strong>{item.roomNumber}</strong>
                              </h3>
                              <h6 class="font-weight-semibold mb-2 text-white">
                                {item.name}
                              </h6>
                              <div class="mb-2">
                                <h6 class="font-weight-semibold mb-2 text-white">
                                  {item.status}
                                </h6>
                                <h6 class="font-weight-semibold mb-2 text-white">
                                  {item.size}
                                </h6>
                              </div>
                            </div>
                          </div>
                        </div>
                      )
                    })
              </div>
            </div>
          </Tab>
        </Tabs>
        {/* </div> */}

        {/* <h1> Fetch data from an api in react </h1> {
				items.map((item) => (
				<ol key = { item.id } >
					User_Name: { item.username },
					Full_Name: { item.name },
					User_Email: { item.email }
					</ol>
				))
			} */}
      </div>
    );
  }
}

export default App;
