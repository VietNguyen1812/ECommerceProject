import logo from "./logo.svg";
import "./App.css";
import Home from "./pages/Home";
import { BrowserRouter as Router, Switch, Route, Link } from "react-router-dom";
import Product from "./pages/Product";
import Category from "./pages/Category";
import Nvarbar from "./Components/Nvarbar";
import Slidebar from "./Components/Slidebar";

function App() {
  return (
    <Router>
      <Nvarbar></Nvarbar>
      <div id="layoutSidenav">
        <Slidebar> </Slidebar>
        <div id="layoutSidenav_content">
          <main>
            <div className="container-fluid px-4">
              <h1 className="mt-4">Dashboard</h1>
              <ol className="breadcrumb mb-4">
                <li className="breadcrumb-item active">Dashboard</li>
              </ol>

              <Switch>
                <Route exact component={Home} path="/" />
                <Route exact component={Product} path="/Product" />
                <Route exact component={Category} path="/Category" />
              </Switch>
            </div>
          </main>
          <footer className="py-4 bg-light mt-auto">
            <div className="container-fluid px-4">
              <div className="d-flex align-items-center justify-content-between small">
                <div className="text-muted">Copyright © Your Website 2021</div>
                <div>
                  <a href="#">Privacy Policy</a>·
                  <a href="#">Terms &amp; Conditions</a>
                </div>
              </div>
            </div>
          </footer>
        </div>
      </div>
    </Router>
  );
}

export default App;
