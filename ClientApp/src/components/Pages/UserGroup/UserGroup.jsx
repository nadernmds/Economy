import React, { Component } from 'react';
import Table from '../../Widgets/Table/Table';
class UserGroup extends Component {
    state = {  }
    columns=[ { title:'گروه کاربری',field:'groupName' }]
    render() { 
        return ( <div>
            <Table url='api/userGroup' primaryKey='userGroupId' columns={this.columns} title="گروه کاربری"/>
        </div> );
    }
}
 
export default UserGroup;