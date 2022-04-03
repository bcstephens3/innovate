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
    if (!DataisLoaded)
      return (
        <div>
          <h1> Your data didn't load :/ </h1>{" "}
        </div>
      );

    return (
      <div class="App">
        {/* <div style={{ display: "block", width: 700, padding: 30 }}> */}
        <h4>React-Bootstrap Tab Component</h4>
        <Tabs defaultActiveKey="second">
          <Tab eventKey="first" title="Dashboard">
            <h1>this is a test</h1>
            <div class="container d-flex justify-content-center mt-50 mb-50 p-5">
              <div class="row">
                {" "}
                {items.map((item) => (
                  <div class="col-md-4 mt-5">
                    <div id="C100/100" class="card">
                      <i
                        id="icon_unavailable"
                        class="bi bi-check-square-fill display-4"
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
          <Tab eventKey="second" title="Setting">
            Hii, I am 2nd tab content
          </Tab>
          <Tab eventKey="third" title="Aboutus">
            Hii, I am 3rd tab content
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
