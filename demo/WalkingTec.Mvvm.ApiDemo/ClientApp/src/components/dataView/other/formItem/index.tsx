import { Input } from 'antd';
import Form, { GetFieldDecoratorOptions, WrappedFormUtils } from 'antd/lib/form/Form';
import { FormItemProps } from 'antd/lib/form/FormItem';
import GlobalConfig from 'global.config'; //全局配置
import lodash from 'lodash';
import { observer } from 'mobx-react';
import * as React from 'react';
const formItemLayout = { ...GlobalConfig.formItemLayout };//布局

/**
 * 表单item
 */
interface IFormItemProps {
    fieId: string;
    /** 模型 */
    models?: {
        [key: string]: {
            label: string,
            rules: any[],
            formItem: React.ReactNode
        };
    };
    /** 禁用 显示 span */
    disabled?: boolean;
    /** 获取默认值 */
    defaultValue?: boolean;
    /** 详情数据 和 defaultValue 共同使用 */
    details?: Object;
    /** Form.Item 的 props */
    formItemProps?: FormItemProps;
    /** 装饰器参数  */
    decoratorOptions?: GetFieldDecoratorOptions;
    /** 覆盖默认渲染 */
    render?: (data: any, fieId: string) => React.ReactNode;
    [key: string]: any;
}
@observer
export class FormItem extends React.Component<IFormItemProps, any> {
    render() {
        const { form = {}, fieId, models, defaultValue, decoratorOptions, formItemProps, details, disabled, render } = this.props;
        const { getFieldDecorator }: WrappedFormUtils = form;
        // 获取模型 item
        const model = lodash.get(models, fieId) || { rules: [], label: `未获取到模型(${fieId})`, formItem: <Input placeholder={`未获取到模型(${fieId})`} /> };
        let options: GetFieldDecoratorOptions = {
            rules: model.rules,
            ...decoratorOptions
        };
        // 获取默认值
        if (defaultValue && typeof defaultValue === "boolean" || disabled && typeof disabled === "boolean") {
            options.initialValue = lodash.get(details, fieId);
        }
        let renderItem = null;
        // 重写渲染
        if (render && typeof render === "function") {
            renderItem = render(options.initialValue, fieId);
        } else {
            // 禁用显示 span
            if (disabled && typeof disabled === "boolean") {
                if (typeof options.initialValue === "object") {
                    renderItem = <span>{JSON.stringify(options.initialValue)}</span>
                } else {
                    renderItem = <span>{options.initialValue}</span>
                }
            } else {
                renderItem = getFieldDecorator && getFieldDecorator(this.props.fieId, options)(model.formItem);
            }
        }
        return <Form.Item label={model.label} {...formItemLayout}  {...formItemProps}>
            {renderItem}
        </Form.Item >
    }
}