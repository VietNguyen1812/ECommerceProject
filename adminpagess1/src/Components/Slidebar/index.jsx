import React from "react";
import { Link } from "react-router-dom";

export default function index() {
  return (
    <>
      <div id="layoutSidenav_nav">
        <nav
          className="sb-sidenav accordion sb-sidenav-dark"
          id="sidenavAccordion"
        >
          <div className="sb-sidenav-menu">
            <div className="nav">
              <div className="sb-sidenav-menu-heading">Core</div>
              <Link className="nav-link" to="/">
                <div className="sb-nav-link-icon">
                  <i className="fas fa-tachometer-alt" />
                </div>
                Home
              </Link>

              <Link className="nav-link" to="/Product">
                <div className="sb-nav-link-icon">
                  <i className="fas fa-chart-area" />
                </div>
                Product
              </Link>
              <Link className="nav-link" to="/Category">
                <div className="sb-nav-link-icon">
                  <i className="fas fa-table" />
                </div>
                Category
              </Link>
            </div>
          </div>
          <div className="sb-sidenav-footer">
            <div className="small">Logged in as:</div>
            Start Bootstrap
          </div>
        </nav>
      </div>
    </>
  );
}
