import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import Login from "./components/Pages/Login/Login";
import Test from "./components/Pages/Test/Test";
import UserGroup from "./components/Pages/UserGroup/UserGroup";
import State from "./components/Pages/State/State";
import User from './components/Pages/User/User'
import SelectCompany from "./components/Pages/SelectCompany/SelectCompany";
import Comapny from "./components/Pages/Company/Company";
import RealPerson from "./components/Pages/RealPerson/RealPerson";
export default class App extends Component {
  static displayName = App.name;
  state = { loggedIn: true };
  render() {
    if (this.state.loggedIn) {
      return (
        <Layout>
          <Route exact path="/userGroup" component={UserGroup} />
          <Route exact path="/state" component={State} />
          <Route exact path="/user" component={User} />
          <Route exact path="/company" component={Comapny} />
          <Route exact path="/realPerson" component={RealPerson} />
          <Route exact path="/selectCompany" component={SelectCompany} />

          <Route path="/test" component={Test} />
          <Route path="/login" component={Login} />

        </Layout>
      );
    } else {
      return <Login />;
    }
  }

  componentDidMount() {
    fetch("api/user/login")
      .then(c => c.json())
      .then(c => {
        this.setState({ loggedIn: c });
      });
  }
}
