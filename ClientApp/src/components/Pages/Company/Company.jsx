import React, { Component } from "react";

import ApiTable from "../../Widgets/Table/ApiTable";
import Table from "../../Widgets/Table/Table";
class Comapny extends Component {
  state = {};
  columns = [{ title: "نام شرکت", field: "companyName" }];
  render() {
    return (
      <div>
        <Table
          url="api/company"
          title="شرکت ها"
          primaryKey="companyId"
          columns={this.columns}
        />
      </div>
    );
  }
}

export default Comapny;
