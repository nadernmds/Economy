import React, { Component } from "react";
import { Route } from "react-router";
import { Layout } from "./components/Layout";
import Login from "./components/Pages/Login/Login";
import Test from "./components/Pages/Test/Test";
import UserGroup from "./components/Pages/UserGroup/UserGroup";

export default class App extends Component {
  static displayName = App.name;
  state = { loggedIn: true };
  render() {
    if (this.state.loggedIn) {
      return (
        <Layout>
          <Route exact path="/userGroup" component={UserGroup} />
          <Route path="/test" component={Test} />

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
