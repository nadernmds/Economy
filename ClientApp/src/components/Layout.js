import React, { Component } from "react";
import NavBar from "./Widgets/NavBar/NavBar";
import MyDrawer from './Widgets/Drawer/Drawer'


export class Layout extends Component {
  static displayName = Layout.name;

  render() {
    return (
      <div>
        <NavBar />
        <div className="uk-grid-small" data-uk-drid>
            <MyDrawer title='نرم افزار مدیریت اطلاعات اقتصادی آستان قدس رضوی'>
              {this.props.children}
            </MyDrawer>
        </div>
      </div>
    );
  }
}
