import logo from './logo.svg';
import './App.css';
import Header from './containers/Header/index';
import React from 'react';
import Product from './containers/Product/index'
import Category from './containers/Category/index';
import FormProduct from './containers/Product/FormProduct';
import FormCategory from './containers/Category/FormCategory';

import { Route, Switch } from 'react-router-dom';
import { PrivateRoute } from './utils/route';
function App() {
  return (
    <div>
      <Header />
      <Switch>

        <Route exact path="/product" component={Product}>
        </Route>

        <Route exact path="/formproduct" component={FormProduct}>
        </Route>

        <Route exact path="/category" component={Category}>
        </Route>

        <Route exact path="/formcategory" component={FormCategory}>
        </Route>
      </Switch>
    </div>
  );
}

export default App;
